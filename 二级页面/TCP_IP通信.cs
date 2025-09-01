using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 网络工具
{
    public partial class TCP_IP通信 : UserControl
    {
        #region === 字段 ===
        private TcpClient tcpClient;
        private NetworkStream netStream;
        private TcpListener listener;
        private int _clientCount = 0;


        private CancellationTokenSource ctsClient, ctsServer;
        #endregion

        public TCP_IP通信() {
           
            InitializeComponent();
            UI使能控制(false);
        }
        

        #region === 事件入口 ===
        private async void 按钮_建立通信(object sender, EventArgs e)
        {
            UI使能控制(true);
            switch (通信方式.Text)
            {
                case "TCP客户端":
                    await StartClientAsync();
                    break;
                case "TCP服务器":
                    await StartServerAsync();
                    break;
                default:
                    UpdateStatus("输入通信状态有误");
                    UI使能控制(false);
                    break;
            }
        }

        private void 数据发送_Click(object sender, EventArgs e) => _ = SendAsync();

        private void 按钮_结束通信_Click(object sender, EventArgs e) => CleanUp();
        #endregion

        #region === 客户端 ===
        private async Task StartClientAsync()
        {
            if (tcpClient?.Connected == true) return;

            try
            {
                tcpClient = new TcpClient();
                await tcpClient.ConnectAsync(输入框_IP地址.Text, int.Parse(输入框_端口号.Text));
                netStream = tcpClient.GetStream();
                UpdateStatus($"已连接");

                ctsClient = new CancellationTokenSource();
                _ = ReceiveLoopAsync(netStream, ctsClient.Token, "服务器");
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接失败：" + ex.Message);
            }
        }
        #endregion

        #region === 服务器 ===
        private async Task StartServerAsync()
        {
            if (listener?.Server?.IsBound == true) return;

            try
            {
                var ip = IPAddress.Parse(输入框_IP地址.Text);
                var port = int.Parse(输入框_端口号.Text);

                listener = new TcpListener(ip, port);
                listener.Start();

                ctsServer = new CancellationTokenSource();
                UpdateStatus("服务器已启动");

                while (!ctsServer.IsCancellationRequested)
                {
                    var client = await listener.AcceptTcpClientAsync();

                    // 计数 +1
                    int newCount = Interlocked.Increment(ref _clientCount);
                    UpdateStatus("在线客户端："+newCount);

                    _ = HandleClientAsync(client, ctsServer.Token);
                }
            }
            catch (Exception ex) when (!(ex is OperationCanceledException))
            {
                MessageBox.Show("服务器异常：" + ex.Message);
            }
        }
        private readonly object _streamLock = new object();   // 用于防止并发写 netStream
        private async Task HandleClientAsync(TcpClient client, CancellationToken token)
        {
            using (client)
            using (var ns = client.GetStream())
            {
                lock (_streamLock) netStream = ns;     // <-- 1. 让发送按钮可用
                try
                {
                    await ReceiveLoopAsync(ns, token, "客户端");
                } finally
                {
                    lock (_streamLock) netStream = null; // <-- 2. 客户端断开时清掉
                                                         // 计数 ‑1
                    int newCount = Interlocked.Decrement(ref _clientCount);
                    UpdateStatus("在线客户端："+newCount);
                }
            }
        }
        #endregion

        #region === 收发公共逻辑 ===
        private async Task ReceiveLoopAsync(NetworkStream ns, CancellationToken token, string peer)//接收数据
        {
            var buf = new byte[1024];
            while (!token.IsCancellationRequested && ns.CanRead)
            {
                try
                {
                    int len = await ns.ReadAsync(buf, 0, buf.Length, token);
                    if (len == 0) break;

                    string display;
                    if (ASCII格式.Checked)        // 字符模式
                    {
                        display = Encoding.UTF8.GetString(buf, 0, len);
                    }
                    else                          // 十六进制模式
                    {
                        display = BytesToHexString(buf, 0, len);
                    }
                    数据日志.AppendText($"{DateTime.Now:HH时mm分ss秒}【收】{display} \r\n");

                    // 服务器回显可按当前模式回显
                    if (listener != null)
                    {
                        byte[] echo = ASCII格式.Checked
                            ? Encoding.UTF8.GetBytes("Echo:OK")
                            : HexStringToBytes("45 63 68 6F 3A 4F 4B"); // "Echo:OK" 的十六进制
                        await ns.WriteAsync(echo, 0, echo.Length, token);
                    }
                }
                catch (IOException) { break; }
                catch (OperationCanceledException) { break; }
            }

            UpdateStatus($"{peer}已断开");
        }

        private async Task SendAsync()//发送数据
        {
            if (netStream?.CanWrite != true) return;

            try
            {
                byte[] buf;
                string showText;

                if (ASCII格式.Checked)        // 字符模式
                {
                    buf     = Encoding.UTF8.GetBytes(发送框.Text + "\r\n");
                    showText = 发送框.Text;
                }
                else                          // 十六进制模式
                {
                    buf     = HexStringToBytes(发送框.Text);
                    showText = BytesToHexString(buf, 0, buf.Length);
                }

                await netStream.WriteAsync(buf, 0, buf.Length);
                数据日志.AppendText($"{DateTime.Now:HH时mm分ss秒}【发】{showText} {Environment.NewLine}");

                发送框.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("发送失败：" + ex.Message);
            }
        }
        #endregion

        #region === 资源清理 ===
        private void CleanUp()
        {
            ctsClient?.Cancel();
            ctsServer?.Cancel();

            netStream?.Close();
            tcpClient?.Close();
            listener?.Stop();

            UI使能控制(false );
            UpdateStatus("已断开所有通信");
        }
        #endregion

        #region === UI 辅助 ===
        private void UpdateStatus(string text) =>
            this.Invoke((MethodInvoker)delegate { 任务栏_状态.Text = $"{ 输入框_IP地址.Text}:{ 输入框_端口号.Text}  {text}"; });


        private void UI使能控制(bool UI)
        {

            结束通信.Enabled=数据发送.Enabled=结束通信.Enabled=UI;

            输入框_IP地址.Enabled=输入框_端口号.Enabled=通信方式.Enabled=建立通信.Enabled=!UI;
        }
        private void 帮助_协议类型(object sender, EventArgs e)
        {
            任务栏_说明.Text="RTU需硬件转接器";

        }
        private void 帮助_站号(object sender, EventArgs e)
        {
            任务栏_说明.Text="TCP不需要站号，仅需要事务号";

        }
        private void 帮助_功能码(object sender, EventArgs e)
        {
            switch (功能码.Text)
            {
                case "0x01：读线圈":
                    任务栏_说明.Text="地址：000001起（1位），数量";
                    break;

                case "0x02：读离散量输入":
                    任务栏_说明.Text="地址：100001起（1位），数量";
                    break;

                case "0x03：读保持寄存器":
                    任务栏_说明.Text="地址：300001起（16位），数量";
                    break;
                case "0x04：读输入寄存器":
                    任务栏_说明.Text="地址：400001起（16位），数量";
                    break;

                case "0x05：写单个线圈":
                    任务栏_说明.Text="值：0-1";
                    break;
                case "0x06：写单个寄存器":
                    任务栏_说明.Text="值：0-65535";
                    break;

                case "0x0F：写多个线圈":
                    任务栏_说明.Text="值：0-1，用空格分隔数据";
                    break;
                case "0x10：写多个寄存器":
                    任务栏_说明.Text="值：0-65535，用空格分隔数据";
                    break;

                default:
                    // 其他情况
                    break;
            }
        }

        private void 帮助_IO目标(object sender, EventArgs e)
        {
            任务栏_说明.Text="输入目标线圈寄存器的数量或值，多个值时用空格分隔";

        }
        private void 帮助_校验方式(object sender, EventArgs e)
        {
            任务栏_说明.Text="仅RTU需要校验";

        }
        private void 帮助_地址(object sender, EventArgs e)
        {
            任务栏_说明.Text="10进制，16进制需0x开头";

        }
        #endregion




        #region === 辅助方法：字符/十六进制互转 ===
        // 把十六进制字符串转成 byte[]
        private byte[] HexStringToBytes(string hex)
        {
            hex = hex.Replace(" ", "");
            if (hex.Length % 2 != 0)
                throw new FormatException("十六进制字符串长度必须为偶数");
            var bytes = new byte[hex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            return bytes;
        }



        // 把 byte[] 转成空格分隔的十六进制字符串
        private string BytesToHexString(byte[] bytes, int offset, int count)
        {
            var sb = new StringBuilder(count * 3);
            for (int i = 0; i < count; i++)
            {
                sb.Append(bytes[offset + i].ToString("X2"));
                if (i < count - 1) sb.Append(' ');
            }
            return sb.ToString();
        }
        #endregion

        //-----------------------------------------Modbus-----------------------------------------
        /*=================== 工具方法 ===================*/
        private static byte ParseHexByte(string s)
        {
            if (s.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                s = s.Substring(2);
            return Convert.ToByte(s, 16);
        }//进制转化
        private static ushort ParseHexUShort(string s)
        {
            if (s.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                s = s.Substring(2);
            return Convert.ToUInt16(s, 16);
        }//进制转化

        /* CRC-16 (Modbus) */
        private static ushort CRC16(byte[] data, int offset, int length)
        {
            ushort crc = 0xFFFF;
            for (int i = offset; i < offset + length; i++)
            {
                crc ^= data[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x0001) != 0)
                        crc = (ushort)((crc >> 1) ^ 0xA001);
                    else
                        crc >>= 1;
                }
            }
            return crc;
        }

        /* CRC-32 */
        private static readonly uint[] crc32Table = Enumerable.Range(0, 256).Select(i =>
        {
            uint c = (uint)i;
            for (int j = 0; j < 8; j++)
                c = (c & 1) != 0 ? (c >> 1) ^ 0xEDB88320 : c >> 1;
            return c;
        }).ToArray();

        private static uint CRC32(byte[] data, int offset, int length)
        {
            uint crc = 0xFFFFFFFF;
            for (int i = offset; i < offset + length; i++)
                crc = crc32Table[(crc ^ data[i]) & 0xFF] ^ (crc >> 8);
            return ~crc;
        }

        /* LRC (ASCII) */
        private static byte LRC(byte[] data, int offset, int length)
        {
            byte lrc = 0;
            for (int i = offset; i < offset + length; i++)
                lrc += data[i];
            return (byte)(-lrc);
        }



        private void 生成数据帧_Click(object sender, EventArgs e)
        {
            OXFF格式.Checked=true;
            try
            {
                /*------------- 读取界面 -------------*/
                byte station = ParseHexByte(站号.Text.Trim());//Trim去掉前后空格
                string proto = 协议类型.Text.Trim().ToUpper();//ToUpper换为大写字母
                string modeStr = 功能码.Text.Trim();
                ushort addr;
                try
                {
                     addr = (ushort)int.Parse(地址.Text.Trim());
                }
                catch {
                     addr = ParseHexUShort(地址.Text.Trim());
                }               
                
                string ioText = IO目标.Text.Trim();
                string chkType = 校验方式.Text.Trim();

                /*------------- 功能码 -------------*/
                string hex = modeStr.Substring(0, 4);
                if (!hex.StartsWith("0x", StringComparison.OrdinalIgnoreCase)) throw new Exception("格式错误！");
                byte fCode = Convert.ToByte(hex, 16);

                /*------------- 构造 PDU -------------*/
                List<byte> pdu = new List<byte>();
                pdu.Add(fCode);
                pdu.Add((byte)(addr >> 8));
                pdu.Add((byte)(addr & 0xFF));

                switch (fCode)
                {
                    /* 01~04：读命令，后跟数量 */
                    case 0x01:
                    case 0x02:
                    case 0x03:
                    case 0x04:
                        ushort qty = ushort.Parse(ioText);
                        pdu.Add((byte)(qty >> 8));
                        pdu.Add((byte)(qty & 0xFF));
                        break;

                    /* 05：写单个线圈 */
                    case 0x05:
                        bool on = ioText == "1";
                        ushort val05 = on ? (ushort)0xFF00 : (ushort)0x0000;
                        pdu.Add((byte)(val05 >> 8));
                        pdu.Add((byte)(val05 & 0xFF));
                        break;

                    /* 06：写单个寄存器 */
                    case 0x06:
                        ushort val06 = ParseHexUShort(ioText);
                        pdu.Add((byte)(val06 >> 8));
                        pdu.Add((byte)(val06 & 0xFF));
                        break;

                    /* 0F：写多个线圈 */
                    case 0x0F:
                        string[] bitsStr = ioText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        bool[] bits = new bool[bitsStr.Length];
                        for (int i = 0; i < bits.Length; i++) bits[i] = bitsStr[i] == "1";
                        int qty0F = bits.Length;
                        int byteCnt = (qty0F + 7) / 8;
                        byte[] coilBytes = new byte[byteCnt];
                        for (int i = 0; i < qty0F; i++)
                            if (bits[i])
                                coilBytes[i >> 3] |= (byte)(1 << (i & 7));

                        pdu.Add((byte)(qty0F >> 8));
                        pdu.Add((byte)(qty0F & 0xFF));
                        pdu.Add((byte)byteCnt);
                        pdu.AddRange(coilBytes);
                        break;

                    /* 10：写多个寄存器 */
                    case 0x10:
                        string[] regsStr = ioText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        ushort[] vals = new ushort[regsStr.Length];
                        for (int i = 0; i < vals.Length; i++) vals[i] = ParseHexUShort(regsStr[i]);
                        int qty10 = vals.Length;
                        pdu.Add((byte)(qty10 >> 8));
                        pdu.Add((byte)(qty10 & 0xFF));
                        pdu.Add((byte)(qty10 * 2));
                        foreach (ushort v in vals)
                        {
                            pdu.Add((byte)(v >> 8));
                            pdu.Add((byte)(v & 0xFF));
                        }
                        break;
                }

                /*------------- 构造 ADU -------------*/
                List<byte> frame = new List<byte>();

                if (proto == "TCP")
                {
                    ushort tid = station;          // 事务标识
                    frame.Add((byte)(tid >> 8));  // 事务标识高
                    frame.Add((byte)(tid & 0xFF));// 事务标识低

                    frame.Add(0);                 // 协议标识高，modbus tcp固定为00 00
                    frame.Add(0);                 // 协议标识低

                    int pduLen = pdu.Count + 1;   // +1 为单元标识符，数据长度
                    frame.Add((byte)(pduLen >> 8));
                    frame.Add((byte)(pduLen & 0xFF));

                    frame.Add(station);           // 单元标识符
                    frame.AddRange(pdu);          // PDU

                    tid++;
                    站号.Text=tid.ToString();
                }
                else if (proto == "RTU")
                {
                    frame.Add(station);
                    frame.AddRange(pdu);
                    AppendChecksum(frame, chkType, frame.ToArray());/* 进入校验 */
                }
                else if (proto == "ASCII")
                {
                    frame.Add(station);
                    frame.AddRange(pdu);
                    byte lrc = LRC(frame.ToArray(), 0, frame.Count);
                    frame.Add(lrc);

                    StringBuilder sb = new StringBuilder(":");
                    foreach (byte b in frame) sb.Append(b.ToString("X2"));
                    sb.Append("\r\n");
                    发送框.Text = sb.ToString();
                    return;
                }
                else
                {
                    throw new Exception("未知协议类型！");
                }

                /*------------- 输出结果 -------------*/
                发送框.Text = string.Join(" ", frame.Select(b => b.ToString("X2")));

                /*======== 局部函数：追加校验 ========*/
                void AppendChecksum(List<byte> list, string type, byte[] data)
                {
                    if (type=="CRC-16 校验")
                    {
                        ushort crc = CRC16(data, 0, data.Length);
                        list.Add((byte)(crc & 0xFF));
                        list.Add((byte)(crc >> 8));
                    }
                    else if (type=="CRC-32 校验")
                    {
                        uint crc = CRC32(data, 0, data.Length);
                        byte[] tmp = BitConverter.GetBytes(crc);
                        list.Add(tmp[0]);
                        list.Add(tmp[1]);
                        list.Add(tmp[2]);
                        list.Add(tmp[3]);
                    }
                    else if (type=="LRC 校验")
                    {
                        byte lrc = LRC(data, 0, data.Length);
                        list.Add(lrc);
                    }

                    /* “无” 或 “奇偶校验” 暂不处理 */
                }
                任务栏_说明.Text="完成";
            }
            catch (Exception ex)
            {
                任务栏_说明.Text="生成失败：" + ex.Message;
            }
        }







    }
}