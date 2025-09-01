
namespace 网络工具
{
    partial class TCP_IP通信
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.输入框_IP地址 = new System.Windows.Forms.TextBox();
            this.输入框_端口号 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.数据日志 = new System.Windows.Forms.TextBox();
            this.lable6 = new System.Windows.Forms.Label();
            this.发送框 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.数据发送 = new System.Windows.Forms.Button();
            this.结束通信 = new System.Windows.Forms.Button();
            this.通信方式 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.建立通信 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.任务栏_状态 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.任务栏_说明 = new System.Windows.Forms.ToolStripStatusLabel();
            this.OXFF格式 = new System.Windows.Forms.RadioButton();
            this.ASCII格式 = new System.Windows.Forms.RadioButton();
            this.数据格式 = new System.Windows.Forms.GroupBox();
            this.通信参数 = new System.Windows.Forms.GroupBox();
            this.Modbus指令 = new System.Windows.Forms.GroupBox();
            this.生成数据帧 = new System.Windows.Forms.Button();
            this.校验方式 = new System.Windows.Forms.ComboBox();
            this.IO目标 = new System.Windows.Forms.TextBox();
            this.地址 = new System.Windows.Forms.TextBox();
            this.功能码 = new System.Windows.Forms.ComboBox();
            this.协议类型 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.站号 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.数据格式.SuspendLayout();
            this.通信参数.SuspendLayout();
            this.Modbus指令.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(384, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 30);
            this.label5.TabIndex = 39;
            this.label5.Text = "TCP/IP通信调试";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "IP地址";
            // 
            // 输入框_IP地址
            // 
            this.输入框_IP地址.Location = new System.Drawing.Point(26, 65);
            this.输入框_IP地址.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.输入框_IP地址.Multiline = true;
            this.输入框_IP地址.Name = "输入框_IP地址";
            this.输入框_IP地址.Size = new System.Drawing.Size(199, 28);
            this.输入框_IP地址.TabIndex = 42;
            this.输入框_IP地址.Text = "192.168.1.99";
            // 
            // 输入框_端口号
            // 
            this.输入框_端口号.Location = new System.Drawing.Point(26, 118);
            this.输入框_端口号.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.输入框_端口号.Multiline = true;
            this.输入框_端口号.Name = "输入框_端口号";
            this.输入框_端口号.Size = new System.Drawing.Size(199, 28);
            this.输入框_端口号.TabIndex = 48;
            this.输入框_端口号.Text = "502";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 47;
            this.label9.Text = "端口号";
            // 
            // 数据日志
            // 
            this.数据日志.Location = new System.Drawing.Point(284, 124);
            this.数据日志.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.数据日志.Multiline = true;
            this.数据日志.Name = "数据日志";
            this.数据日志.ReadOnly = true;
            this.数据日志.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.数据日志.Size = new System.Drawing.Size(677, 561);
            this.数据日志.TabIndex = 53;
            this.数据日志.TabStop = false;
            // 
            // lable6
            // 
            this.lable6.AutoSize = true;
            this.lable6.Location = new System.Drawing.Point(281, 104);
            this.lable6.Name = "lable6";
            this.lable6.Size = new System.Drawing.Size(80, 18);
            this.lable6.TabIndex = 54;
            this.lable6.Text = "数据日志";
            // 
            // 发送框
            // 
            this.发送框.Location = new System.Drawing.Point(284, 735);
            this.发送框.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.发送框.Multiline = true;
            this.发送框.Name = "发送框";
            this.发送框.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.发送框.Size = new System.Drawing.Size(614, 84);
            this.发送框.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 715);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 58;
            this.label6.Text = "发送框";
            // 
            // 数据发送
            // 
            this.数据发送.Location = new System.Drawing.Point(904, 735);
            this.数据发送.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.数据发送.Name = "数据发送";
            this.数据发送.Size = new System.Drawing.Size(57, 84);
            this.数据发送.TabIndex = 59;
            this.数据发送.Text = "数据发送";
            this.数据发送.UseVisualStyleBackColor = true;
            this.数据发送.Click += new System.EventHandler(this.数据发送_Click);
            // 
            // 结束通信
            // 
            this.结束通信.Location = new System.Drawing.Point(26, 257);
            this.结束通信.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.结束通信.Name = "结束通信";
            this.结束通信.Size = new System.Drawing.Size(199, 26);
            this.结束通信.TabIndex = 60;
            this.结束通信.Text = "结束通信";
            this.结束通信.UseVisualStyleBackColor = true;
            this.结束通信.Click += new System.EventHandler(this.按钮_结束通信_Click);
            // 
            // 通信方式
            // 
            this.通信方式.FormattingEnabled = true;
            this.通信方式.Items.AddRange(new object[] {
            "TCP客户端",
            "TCP服务器"});
            this.通信方式.Location = new System.Drawing.Point(26, 177);
            this.通信方式.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.通信方式.Name = "通信方式";
            this.通信方式.Size = new System.Drawing.Size(199, 26);
            this.通信方式.TabIndex = 61;
            this.通信方式.Text = "TCP客户端";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 62;
            this.label2.Text = "通信模式";
            // 
            // 建立通信
            // 
            this.建立通信.Location = new System.Drawing.Point(26, 232);
            this.建立通信.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.建立通信.Name = "建立通信";
            this.建立通信.Size = new System.Drawing.Size(199, 26);
            this.建立通信.TabIndex = 63;
            this.建立通信.Text = "建立通信";
            this.建立通信.UseVisualStyleBackColor = true;
            this.建立通信.Click += new System.EventHandler(this.按钮_建立通信);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.任务栏_状态,
            this.toolStripStatusLabel1,
            this.任务栏_说明});
            this.statusStrip1.Location = new System.Drawing.Point(0, 968);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1000, 32);
            this.statusStrip1.TabIndex = 64;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(66, 25);
            this.toolStripStatusLabel3.Text = "状态：";
            // 
            // 任务栏_状态
            // 
            this.任务栏_状态.ForeColor = System.Drawing.Color.White;
            this.任务栏_状态.Name = "任务栏_状态";
            this.任务栏_状态.Size = new System.Drawing.Size(30, 25);
            this.任务栏_状态.Text = "//";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(859, 25);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "帮助：";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 任务栏_说明
            // 
            this.任务栏_说明.ForeColor = System.Drawing.Color.White;
            this.任务栏_说明.Name = "任务栏_说明";
            this.任务栏_说明.Size = new System.Drawing.Size(30, 25);
            this.任务栏_说明.Text = "//";
            // 
            // OXFF格式
            // 
            this.OXFF格式.AutoSize = true;
            this.OXFF格式.Location = new System.Drawing.Point(100, 28);
            this.OXFF格式.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OXFF格式.Name = "OXFF格式";
            this.OXFF格式.Size = new System.Drawing.Size(123, 22);
            this.OXFF格式.TabIndex = 65;
            this.OXFF格式.Text = "16进制格式";
            this.OXFF格式.UseVisualStyleBackColor = true;
            // 
            // ASCII格式
            // 
            this.ASCII格式.AutoSize = true;
            this.ASCII格式.Checked = true;
            this.ASCII格式.Location = new System.Drawing.Point(100, 55);
            this.ASCII格式.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ASCII格式.Name = "ASCII格式";
            this.ASCII格式.Size = new System.Drawing.Size(114, 22);
            this.ASCII格式.TabIndex = 66;
            this.ASCII格式.TabStop = true;
            this.ASCII格式.Text = "ASCII格式";
            this.ASCII格式.UseVisualStyleBackColor = true;
            // 
            // 数据格式
            // 
            this.数据格式.Controls.Add(this.OXFF格式);
            this.数据格式.Controls.Add(this.ASCII格式);
            this.数据格式.Location = new System.Drawing.Point(284, 850);
            this.数据格式.Name = "数据格式";
            this.数据格式.Size = new System.Drawing.Size(250, 93);
            this.数据格式.TabIndex = 68;
            this.数据格式.TabStop = false;
            this.数据格式.Text = "数据格式：";
            // 
            // 通信参数
            // 
            this.通信参数.Controls.Add(this.label1);
            this.通信参数.Controls.Add(this.输入框_IP地址);
            this.通信参数.Controls.Add(this.label9);
            this.通信参数.Controls.Add(this.建立通信);
            this.通信参数.Controls.Add(this.输入框_端口号);
            this.通信参数.Controls.Add(this.label2);
            this.通信参数.Controls.Add(this.结束通信);
            this.通信参数.Controls.Add(this.通信方式);
            this.通信参数.Location = new System.Drawing.Point(15, 104);
            this.通信参数.Name = "通信参数";
            this.通信参数.Size = new System.Drawing.Size(250, 303);
            this.通信参数.TabIndex = 69;
            this.通信参数.TabStop = false;
            this.通信参数.Text = "通信参数：";
            // 
            // Modbus指令
            // 
            this.Modbus指令.Controls.Add(this.生成数据帧);
            this.Modbus指令.Controls.Add(this.校验方式);
            this.Modbus指令.Controls.Add(this.IO目标);
            this.Modbus指令.Controls.Add(this.地址);
            this.Modbus指令.Controls.Add(this.功能码);
            this.Modbus指令.Controls.Add(this.协议类型);
            this.Modbus指令.Controls.Add(this.label11);
            this.Modbus指令.Controls.Add(this.站号);
            this.Modbus指令.Controls.Add(this.label10);
            this.Modbus指令.Controls.Add(this.label8);
            this.Modbus指令.Controls.Add(this.label7);
            this.Modbus指令.Controls.Add(this.label4);
            this.Modbus指令.Controls.Add(this.label3);
            this.Modbus指令.Location = new System.Drawing.Point(15, 435);
            this.Modbus指令.Name = "Modbus指令";
            this.Modbus指令.Size = new System.Drawing.Size(250, 508);
            this.Modbus指令.TabIndex = 70;
            this.Modbus指令.TabStop = false;
            this.Modbus指令.Text = "Modbus指令";
            // 
            // 生成数据帧
            // 
            this.生成数据帧.Location = new System.Drawing.Point(26, 443);
            this.生成数据帧.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.生成数据帧.Name = "生成数据帧";
            this.生成数据帧.Size = new System.Drawing.Size(199, 49);
            this.生成数据帧.TabIndex = 64;
            this.生成数据帧.Text = "生成数据帧";
            this.生成数据帧.UseVisualStyleBackColor = true;
            this.生成数据帧.Click += new System.EventHandler(this.生成数据帧_Click);
            // 
            // 校验方式
            // 
            this.校验方式.FormattingEnabled = true;
            this.校验方式.Items.AddRange(new object[] {
            "无",
            "奇偶校验（硬件配置）",
            "CRC-16 校验",
            "CRC-32 校验",
            "LRC 校验"});
            this.校验方式.Location = new System.Drawing.Point(26, 384);
            this.校验方式.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.校验方式.Name = "校验方式";
            this.校验方式.Size = new System.Drawing.Size(199, 26);
            this.校验方式.TabIndex = 76;
            this.校验方式.Text = "无";
            this.校验方式.TextChanged += new System.EventHandler(this.帮助_校验方式);
            this.校验方式.Click += new System.EventHandler(this.帮助_校验方式);
            // 
            // IO目标
            // 
            this.IO目标.Location = new System.Drawing.Point(26, 315);
            this.IO目标.Multiline = true;
            this.IO目标.Name = "IO目标";
            this.IO目标.Size = new System.Drawing.Size(199, 28);
            this.IO目标.TabIndex = 75;
            this.IO目标.Text = "1";
            this.IO目标.Click += new System.EventHandler(this.帮助_IO目标);
            // 
            // 地址
            // 
            this.地址.Location = new System.Drawing.Point(26, 253);
            this.地址.Multiline = true;
            this.地址.Name = "地址";
            this.地址.Size = new System.Drawing.Size(199, 28);
            this.地址.TabIndex = 74;
            this.地址.Text = "0x0001";
            this.地址.Click += new System.EventHandler(this.帮助_地址);
            // 
            // 功能码
            // 
            this.功能码.FormattingEnabled = true;
            this.功能码.Items.AddRange(new object[] {
            "0x01：读线圈",
            "0x02：读离散量输入",
            "0x03：读保持寄存器",
            "0x04：读输入寄存器",
            "0x05：写单个线圈",
            "0x06：写单个寄存器",
            "0x0F：写多个线圈",
            "0x10：写多个寄存器"});
            this.功能码.Location = new System.Drawing.Point(26, 197);
            this.功能码.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.功能码.Name = "功能码";
            this.功能码.Size = new System.Drawing.Size(199, 26);
            this.功能码.TabIndex = 73;
            this.功能码.Text = "0x01：读线圈";
            this.功能码.TextChanged += new System.EventHandler(this.帮助_功能码);
            this.功能码.Click += new System.EventHandler(this.帮助_功能码);
            // 
            // 协议类型
            // 
            this.协议类型.FormattingEnabled = true;
            this.协议类型.Items.AddRange(new object[] {
            "RTU",
            "TCP",
            "ASCII"});
            this.协议类型.Location = new System.Drawing.Point(26, 68);
            this.协议类型.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.协议类型.Name = "协议类型";
            this.协议类型.Size = new System.Drawing.Size(199, 26);
            this.协议类型.TabIndex = 64;
            this.协议类型.Text = "RTU";
            this.协议类型.TextChanged += new System.EventHandler(this.帮助_协议类型);
            this.协议类型.Click += new System.EventHandler(this.帮助_协议类型);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 18);
            this.label11.TabIndex = 72;
            this.label11.Text = "协议类型";
            // 
            // 站号
            // 
            this.站号.Location = new System.Drawing.Point(26, 132);
            this.站号.Multiline = true;
            this.站号.Name = "站号";
            this.站号.Size = new System.Drawing.Size(199, 28);
            this.站号.TabIndex = 71;
            this.站号.Text = "0x01";
            this.站号.Click += new System.EventHandler(this.帮助_站号);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 18);
            this.label10.TabIndex = 68;
            this.label10.Text = "校验方式（仅RTU）";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 67;
            this.label8.Text = "IO数量/值";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 66;
            this.label7.Text = "目标地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 65;
            this.label4.Text = "功能码选择";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 64;
            this.label3.Text = "对方站号";
            // 
            // TCP_IP通信
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Modbus指令);
            this.Controls.Add(this.通信参数);
            this.Controls.Add(this.数据格式);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.数据发送);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.发送框);
            this.Controls.Add(this.lable6);
            this.Controls.Add(this.数据日志);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TCP_IP通信";
            this.Size = new System.Drawing.Size(1000, 1000);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.数据格式.ResumeLayout(false);
            this.数据格式.PerformLayout();
            this.通信参数.ResumeLayout(false);
            this.通信参数.PerformLayout();
            this.Modbus指令.ResumeLayout(false);
            this.Modbus指令.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion




        private System.Windows.Forms.Label lable6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;


        private System.Windows.Forms.GroupBox 通信参数;
        private System.Windows.Forms.TextBox 输入框_端口号;        
        private System.Windows.Forms.TextBox 输入框_IP地址;
        private System.Windows.Forms.TextBox 数据日志;
        private System.Windows.Forms.ComboBox 通信方式;
        private System.Windows.Forms.Button 结束通信;
        private System.Windows.Forms.Button 建立通信;
        private System.Windows.Forms.Button 数据发送;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel 任务栏_状态;

        private System.Windows.Forms.GroupBox 数据格式;
        private System.Windows.Forms.RadioButton OXFF格式;
        private System.Windows.Forms.RadioButton ASCII格式;
        

        private System.Windows.Forms.GroupBox Modbus指令;
        private System.Windows.Forms.TextBox 站号;        
        private System.Windows.Forms.ComboBox 协议类型;
        private System.Windows.Forms.TextBox 地址;
        private System.Windows.Forms.ComboBox 校验方式;
        private System.Windows.Forms.TextBox IO目标;
        private System.Windows.Forms.TextBox 发送框;
        private System.Windows.Forms.Button 生成数据帧;
        private System.Windows.Forms.ComboBox 功能码;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel 任务栏_说明;
    }
}
