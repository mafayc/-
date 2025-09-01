using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.ComponentModel;
using System.Runtime.InteropServices;


namespace 网络工具
{

    public partial class 本机调试 : UserControl
    {
        private int _序号;
        private int 应用pid = 0;
        private const int Ping超时 = 50;
        public 本机调试()
        {
            InitializeComponent();
            label_日志文本.Text = $"使用方法：\n1.刷新网络\n2.在列表中选中需要更改的网络\n3.修改IP参数点击应用";
            按钮功能开关(false);
            if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))//检查管理员权限
            { label_日志文本.Text += "\n管理员权限正常"; }
            else { label_日志文本.Text += "\n请使用管理员权限打开"; }
            刷新网络接口列表();
        }

        //══════════════════════════ 事件处理 ══════════════════════════
        private void button_刷新网络_Click(object sender, EventArgs e)
        {
            label_日志文本.Text = "刷新网络列表中...";
            刷新网络接口列表();
            label_日志文本.Text += "\n完成";
        }

        private void listView_ip显示_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_ip显示.SelectedItems.Count == 0) return;
            var item = listView_ip显示.SelectedItems[0];
            textBox_网络名称文本框.Text    = item.SubItems[0].Text;
            textBox_ip文本框.Text          = item.SubItems[2].Text;
            textBox_子网掩码文本框.Text    = item.SubItems[3].Text;
            textBox_ping.Text              = item.SubItems[2].Text;
            按钮功能开关(true);// 启用操作按钮
        }

        private void button_ping_Click(object sender, EventArgs e)
        {
            textBox_网段内设备列表.Text = "正在Ping设备...\r\n";
            var ip = textBox_ping.Text;
            if (string.IsNullOrWhiteSpace(ip)) return;

            try
            {
                using (var ping工具 = new Ping())
                {
                    var 响应结果 = ping工具.Send(ip, 1000);
                    textBox_网段内设备列表.Text += $"\r\n目标: {ip}\r\n状态: {响应结果.Status}";

                    if (响应结果.Status == IPStatus.Success)
                    {
                        var hostEntry = Dns.GetHostEntry(响应结果.Address);
                        textBox_网段内设备列表.Text += $"\r\n主机名: {hostEntry.HostName}";
                        textBox_网段内设备列表.Text += $"\r\n延迟: {响应结果.RoundtripTime}ms";
                    }
                }
            }
            catch (Exception ex)
            {
                textBox_网段内设备列表.Text += $"\r\n错误: {ex.Message}";
            }
        }

        private async void button_ping网段_Click(object sender, EventArgs e)
        {
            _序号 = 0;
            string 目标网段 = textBox_ping.Text.Substring(0, textBox_ping.Text.LastIndexOf('.') + 1);//提取IP网段

            textBox_网段内设备列表.Text = "序号   IP地址        延迟";
            label_日志文本.Text = $"正在扫描: {目标网段}网段";
            var tasks = new List<Task>();
            var semaphore = new SemaphoreSlim(15); // 限制最大并发数

            for (int i = 1; i < 245; i++)
            {
                var 目标ip = $"{目标网段}{i}";
                label_日志文本.Text = $"正在扫描: {目标ip}";
                await semaphore.WaitAsync();
                tasks.Add(Task.Run(async () =>
                {
                    try
                    {
                        using (var ping工具 = new Ping())
                        {
                            var 响应结果 = await ping工具.SendPingAsync(目标ip, Ping超时);
                            this.Invoke((MethodInvoker)delegate { 更新界面状态(响应结果); });
                        }
                    } finally { semaphore.Release(); }
                }));
            }
            await Task.WhenAll(tasks);
            textBox_网段内设备列表.Text += "\r\n扫描完成";
        }

        private void button_修改网络参数_Click(object sender, EventArgs e)
        {
            bool 修改结果 = false;  // 初始化默认值

            if (checkBox_自动.Checked)
            {
                label_日志文本.Text = textBox_子网掩码文本框.Text = textBox_ip文本框.Text = "自动获取\n";//设置ip为自动获取模式。
                修改结果 = 设置网络参数(textBox_网络名称文本框.Text);
            }
            else
            {
                label_日志文本.Text = "手动设置\n";
                if (Regex.IsMatch((textBox_ip文本框.Text), @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$"))//验证ip格式
                {
                    修改结果 = 设置网络参数(textBox_网络名称文本框.Text, textBox_ip文本框.Text, textBox_子网掩码文本框.Text);
                    textBox_ping.Text = textBox_ip文本框.Text;
                }
                else { label_日志文本.Text = "IP地址格式无效"; }
            }
            label_日志文本.Text += 修改结果 ? "修改成功" : "修改失败";
            从注册表刷新网络列表();
        }

        private void button_注册表刷新网络_Click(object sender, EventArgs e)
        {
            label_日志文本.Text = "刷新网络列表中...";
            从注册表刷新网络列表();
            listView_ip显示.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            label_日志文本.Text += "\n完成";
        }

        private void button_控制面板_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "ncpa.cpl",
                    Verb = "runas",
                    UseShellExecute = true
                });
            }
            catch (Exception ex) { MessageBox.Show($"打开失败: {ex.Message}"); }
        }


        private void checkBox_自动_Click(object sender, EventArgs e)
        {
            textBox_ip文本框.Enabled = textBox_子网掩码文本框.Enabled = !textBox_ip文本框.Enabled;
        }


        private async void button_ping端口_Click(object sender, EventArgs e)
        {
            // 获取输入值
            string ip = textBox_ping.Text.Trim();
            string portText = textBox_远方端口.Text.Trim();

            // 基本验证
            if (string.IsNullOrEmpty(ip) || string.IsNullOrEmpty(portText))
            {
                textBox_网段内设备列表.Text = "请输入IP地址和端口号";
                return;
            }

            // 设置超时时间（毫秒）
            const int timeout = 2000;

            try
            {
                // 显示扫描状态
                textBox_网段内设备列表.Text = $"正在扫描 {ip}:{portText}...";

                // 创建TCP客户端
                using (TcpClient client = new TcpClient())
                {
                    // 异步连接任务
                    var connectTask = client.ConnectAsync(ip, int.Parse(portText));

                    // 等待连接完成或超时
                    if (await Task.WhenAny(connectTask, Task.Delay(timeout)) == connectTask)
                    {
                        // 检查实际连接状态
                        textBox_网段内设备列表.Text = client.Connected ?
                            $"✓ {ip}:{portText} 端口开放" :
                            $"✗ {ip}:{portText} 端口关闭";
                    }
                    else
                    {
                        textBox_网段内设备列表.Text = $"✗ {ip}:{portText} 端口关闭 (超时)";
                    }
                }
            }
            catch (Exception ex)
            {
                // 精简的错误处理
                textBox_网段内设备列表.Text = $"扫描失败: {ex.Message.Replace("\r", "").Replace("\n", "")}";
            }
        }



        // 按钮1：检查端口
        private void button_检查端口_Click(object sender, EventArgs e)
        {
            应用pid = -1;
            int port = int.Parse(textBox_本机端口.Text);
            using (var process = new Process())
            {
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c netstat -ano | findstr :{port}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                foreach (string line in output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 5 && parts[1].Contains($":{port}"))
                    {
                        应用pid = int.Parse(parts[4]);
                    }
                }
            }


            try
            {
                if (应用pid == -1)
                {
                    textBox_网段内设备列表.Text = $"端口 {textBox_本机端口.Text} 未被占用。";
                }
                else
                {
                    string processName = Process.GetProcessById(应用pid).ProcessName;
                    textBox_网段内设备列表.Text = $"\r\n端口 {textBox_本机端口.Text} 被占用！\r\nPID: {应用pid}\r\n进程名: {processName}";
                }
            }
            catch (Exception ex)
            {
                textBox_网段内设备列表.Text = $"\r\n检查端口时出错：\r\n{ex.Message}";
            }
        }

        // 按钮2：终止端口进程
        private void button_端口进程终结_Click(object sender, EventArgs e)
        {
            try
            {
                Process targetProcess = Process.GetProcessById(应用pid);
                targetProcess.Kill();
                targetProcess.WaitForExit(1000);
                textBox_网段内设备列表.Text += $"\r\n成功终止该进程。";
            }
            catch (Exception ex)
            {
                textBox_网段内设备列表.Text += $"\r\n终止进程失败:\r\n {ex.Message}";
            }

        }
        //══════════════════════════ 功能实现 ══════════════════════════
        private void 按钮功能开关(bool b)
        {
            textBox_远方端口.Enabled = button_ping端口.Enabled =  checkBox_自动.Enabled= button_修改网络参数.Enabled = button_ping.Enabled = button_ping网段.Enabled = b;
        }

        private void 更新界面状态(PingReply 响应结果)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => 更新界面状态(响应结果)));
                return;
            }

            if (响应结果.Status != IPStatus.Success) return;
            textBox_网段内设备列表.Text += $"\r\n {++_序号,-5} {响应结果.Address,-15} {响应结果.RoundtripTime}ms";
        }

        private void 刷新网络接口列表()
        {
            listView_ip显示.BeginUpdate();
            listView_ip显示.Items.Clear();

            foreach (var 适配器 in NetworkInterface.GetAllNetworkInterfaces())
            {
                var 列表项 = new ListViewItem(适配器.Name);
                列表项.SubItems.Add(适配器.OperationalStatus.ToString());
                var 属性 = 适配器.GetIPProperties();

                var ipInfo = 属性.UnicastAddresses.FirstOrDefault(a => a.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                列表项.SubItems.Add(ipInfo?.Address.ToString() ?? "未配置");
                列表项.SubItems.Add(ipInfo?.IPv4Mask.ToString() ?? "未配置");
                列表项.SubItems.Add(属性.GatewayAddresses.FirstOrDefault()?.Address.ToString() ?? "未配置");

                listView_ip显示.Items.Add(列表项);
            }
            listView_ip显示.EndUpdate();
            listView_ip显示.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        private void 从注册表刷新网络列表()
        {
            listView_ip显示.Items.Clear();
            using (var 注册表根键 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                foreach (var 适配器 in NetworkInterface.GetAllNetworkInterfaces().Where(n => n.NetworkInterfaceType == NetworkInterfaceType.Ethernet))
                {
                    var item = new ListViewItem(适配器.Name);
                    item.SubItems.Add(适配器.OperationalStatus.ToString());

                    string 路径 = $@"SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\{适配器.Id}";
                    using (var key = 注册表根键.OpenSubKey(路径))
                    {
                        if (key == null) continue;

                        if (key.GetValue("EnableDHCP") is int dhcp && dhcp == 0)
                        {
                            item.SubItems.Add((key.GetValue("IPAddress") as string[])?.FirstOrDefault() ?? "未配置");
                            item.SubItems.Add((key.GetValue("SubnetMask") as string[])?.FirstOrDefault() ?? "未配置");
                        }
                        else
                        {
                            item.SubItems.Add("使用DHCP");
                            item.SubItems.Add("使用DHCP");
                        }
                    }
                    listView_ip显示.Items.Add(item);
                }
            }
        }

        private bool 设置网络参数(string 接口名称, string ip = null, string 子网掩码 = null)
        {
            try
            {
                string arguments;
                if (string.IsNullOrEmpty(ip))// DHCP模式
                {
                    arguments = $"interface ip set address name=\"{接口名称}\" source=dhcp";
                }
                else // 静态IP模式
                {
                    if (string.IsNullOrEmpty(子网掩码))
                        throw new ArgumentException("设置静态IP时必须提供子网掩码");

                    arguments = $"interface ip set address name=\"{接口名称}\" source=static addr={ip} mask={子网掩码}";
                }

                using (var process = Process.Start(new ProcessStartInfo
                {
                    FileName = "netsh",
                    Arguments = arguments,
                    Verb = "runas",
                    UseShellExecute = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                }))
                {
                    process?.WaitForExit();
                    return process?.ExitCode == 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"网络参数设置失败：{ex.Message}");
                return false;
            }
        }


    }
}