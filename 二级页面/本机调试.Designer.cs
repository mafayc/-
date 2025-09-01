
namespace 网络工具
{
    partial class 本机调试
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.button_ping = new System.Windows.Forms.Button();
            this.button_本机进程终结 = new System.Windows.Forms.Button();
            this.textBox_本机端口 = new System.Windows.Forms.TextBox();
            this.button_本机端口检查 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.显示本机IP信息 = new System.Windows.Forms.GroupBox();
            this.刷新网络 = new System.Windows.Forms.Button();
            this.listView_ip显示 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_WL = new System.Windows.Forms.Button();
            this.注册刷新网络 = new System.Windows.Forms.Button();
            this.按钮提示 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox_自动 = new System.Windows.Forms.CheckBox();
            this.button_ping端口 = new System.Windows.Forms.Button();
            this.button_修改网络参数 = new System.Windows.Forms.Button();
            this.button_ping网段 = new System.Windows.Forms.Button();
            this.textBox_ping = new System.Windows.Forms.TextBox();
            this.修改本机IP信息 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ip文本框 = new System.Windows.Forms.TextBox();
            this.textBox_子网掩码文本框 = new System.Windows.Forms.TextBox();
            this.textBox_网络名称文本框 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.探测外界IP = new System.Windows.Forms.GroupBox();
            this.textBox_远方端口 = new System.Windows.Forms.TextBox();
            this.textBox_网段内设备列表 = new System.Windows.Forms.TextBox();
            this.label_日志文本 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.显示本机IP信息.SuspendLayout();
            this.修改本机IP信息.SuspendLayout();
            this.探测外界IP.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(98, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "ping工具";
            // 
            // button_ping
            // 
            this.button_ping.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_ping.Location = new System.Drawing.Point(30, 90);
            this.button_ping.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_ping.Name = "button_ping";
            this.button_ping.Size = new System.Drawing.Size(102, 28);
            this.button_ping.TabIndex = 13;
            this.button_ping.Text = "ping设备";
            this.按钮提示.SetToolTip(this.button_ping, "ping对方的延迟、名称");
            this.button_ping.UseVisualStyleBackColor = true;
            this.button_ping.Click += new System.EventHandler(this.button_ping_Click);
            // 
            // button_本机进程终结
            // 
            this.button_本机进程终结.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_本机进程终结.Location = new System.Drawing.Point(138, 402);
            this.button_本机进程终结.Name = "button_本机进程终结";
            this.button_本机进程终结.Size = new System.Drawing.Size(102, 28);
            this.button_本机进程终结.TabIndex = 28;
            this.button_本机进程终结.Text = "终结";
            this.button_本机进程终结.UseVisualStyleBackColor = true;
            this.button_本机进程终结.Click += new System.EventHandler(this.button_端口进程终结_Click);
            // 
            // textBox_本机端口
            // 
            this.textBox_本机端口.Location = new System.Drawing.Point(24, 364);
            this.textBox_本机端口.Name = "textBox_本机端口";
            this.textBox_本机端口.Size = new System.Drawing.Size(216, 28);
            this.textBox_本机端口.TabIndex = 27;
            this.textBox_本机端口.Text = "0";
            this.textBox_本机端口.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_本机端口检查
            // 
            this.button_本机端口检查.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_本机端口检查.Location = new System.Drawing.Point(24, 402);
            this.button_本机端口检查.Name = "button_本机端口检查";
            this.button_本机端口检查.Size = new System.Drawing.Size(102, 28);
            this.button_本机端口检查.TabIndex = 26;
            this.button_本机端口检查.Text = "检查";
            this.button_本机端口检查.UseVisualStyleBackColor = true;
            this.button_本机端口检查.Click += new System.EventHandler(this.button_检查端口_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(38, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "检查本机端口占用情况";
            // 
            // 显示本机IP信息
            // 
            this.显示本机IP信息.Controls.Add(this.刷新网络);
            this.显示本机IP信息.Controls.Add(this.listView_ip显示);
            this.显示本机IP信息.Controls.Add(this.button_WL);
            this.显示本机IP信息.Controls.Add(this.注册刷新网络);
            this.显示本机IP信息.Location = new System.Drawing.Point(22, 148);
            this.显示本机IP信息.Name = "显示本机IP信息";
            this.显示本机IP信息.Size = new System.Drawing.Size(946, 359);
            this.显示本机IP信息.TabIndex = 35;
            this.显示本机IP信息.TabStop = false;
            this.显示本机IP信息.Text = "显示本机IP信息";
            // 
            // 刷新网络
            // 
            this.刷新网络.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.刷新网络.Location = new System.Drawing.Point(28, 27);
            this.刷新网络.Name = "刷新网络";
            this.刷新网络.Size = new System.Drawing.Size(189, 30);
            this.刷新网络.TabIndex = 20;
            this.刷新网络.Text = "刷新（当前连接）";
            this.按钮提示.SetToolTip(this.刷新网络, "该功能无法获取断联端口ip");
            this.刷新网络.UseVisualStyleBackColor = true;
            this.刷新网络.Click += new System.EventHandler(this.button_刷新网络_Click);
            // 
            // listView_ip显示
            // 
            this.listView_ip显示.BackColor = System.Drawing.SystemColors.Control;
            this.listView_ip显示.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_ip显示.FullRowSelect = true;
            this.listView_ip显示.HideSelection = false;
            this.listView_ip显示.Location = new System.Drawing.Point(28, 63);
            this.listView_ip显示.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listView_ip显示.Name = "listView_ip显示";
            this.listView_ip显示.Size = new System.Drawing.Size(895, 276);
            this.listView_ip显示.TabIndex = 3;
            this.listView_ip显示.TabStop = false;
            this.按钮提示.SetToolTip(this.listView_ip显示, "本机ip显示区域");
            this.listView_ip显示.UseCompatibleStateImageBehavior = false;
            this.listView_ip显示.View = System.Windows.Forms.View.Details;
            this.listView_ip显示.SelectedIndexChanged += new System.EventHandler(this.listView_ip显示_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "接口名称";
            this.columnHeader1.Width = 136;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "是否连接";
            this.columnHeader2.Width = 176;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "本机IP地址";
            this.columnHeader3.Width = 158;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "子网掩码";
            this.columnHeader4.Width = 158;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "默认网关";
            this.columnHeader5.Width = 411;
            // 
            // button_WL
            // 
            this.button_WL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_WL.Location = new System.Drawing.Point(734, 27);
            this.button_WL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_WL.Name = "button_WL";
            this.button_WL.Size = new System.Drawing.Size(189, 30);
            this.button_WL.TabIndex = 19;
            this.button_WL.Text = "打开\"网络连接\"";
            this.按钮提示.SetToolTip(this.button_WL, "控制面板中的\"网络连接\"功能");
            this.button_WL.UseVisualStyleBackColor = true;
            this.button_WL.Click += new System.EventHandler(this.button_控制面板_Click);
            // 
            // 注册刷新网络
            // 
            this.注册刷新网络.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.注册刷新网络.Location = new System.Drawing.Point(224, 27);
            this.注册刷新网络.Name = "注册刷新网络";
            this.注册刷新网络.Size = new System.Drawing.Size(189, 30);
            this.注册刷新网络.TabIndex = 21;
            this.注册刷新网络.Text = "刷新（注册表）";
            this.按钮提示.SetToolTip(this.注册刷新网络, "该功能仅能获取部分端口真实ip");
            this.注册刷新网络.UseVisualStyleBackColor = true;
            this.注册刷新网络.Click += new System.EventHandler(this.button_注册表刷新网络_Click);
            // 
            // checkBox_自动
            // 
            this.checkBox_自动.AutoSize = true;
            this.checkBox_自动.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox_自动.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox_自动.Location = new System.Drawing.Point(77, 250);
            this.checkBox_自动.Name = "checkBox_自动";
            this.checkBox_自动.Size = new System.Drawing.Size(130, 22);
            this.checkBox_自动.TabIndex = 24;
            this.checkBox_自动.Text = "自动获取IP";
            this.按钮提示.SetToolTip(this.checkBox_自动, "有路由器自动分配本设备IP地址");
            this.checkBox_自动.UseVisualStyleBackColor = true;
            // 
            // button_ping端口
            // 
            this.button_ping端口.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_ping端口.Location = new System.Drawing.Point(144, 127);
            this.button_ping端口.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_ping端口.Name = "button_ping端口";
            this.button_ping端口.Size = new System.Drawing.Size(102, 28);
            this.button_ping端口.TabIndex = 30;
            this.button_ping端口.Text = "ping端口";
            this.按钮提示.SetToolTip(this.button_ping端口, "ping对方的延迟、名称");
            this.button_ping端口.UseVisualStyleBackColor = true;
            this.button_ping端口.Click += new System.EventHandler(this.button_ping端口_Click);
            // 
            // button_修改网络参数
            // 
            this.button_修改网络参数.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_修改网络参数.Location = new System.Drawing.Point(24, 278);
            this.button_修改网络参数.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_修改网络参数.Name = "button_修改网络参数";
            this.button_修改网络参数.Size = new System.Drawing.Size(216, 28);
            this.button_修改网络参数.TabIndex = 9;
            this.button_修改网络参数.Text = "应用";
            this.按钮提示.SetToolTip(this.button_修改网络参数, "应用改网络名称下ip、掩码的设置");
            this.button_修改网络参数.UseVisualStyleBackColor = true;
            this.button_修改网络参数.Click += new System.EventHandler(this.button_修改网络参数_Click);
            // 
            // button_ping网段
            // 
            this.button_ping网段.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_ping网段.Location = new System.Drawing.Point(144, 90);
            this.button_ping网段.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_ping网段.Name = "button_ping网段";
            this.button_ping网段.Size = new System.Drawing.Size(102, 28);
            this.button_ping网段.TabIndex = 16;
            this.button_ping网段.Text = "ping网段";
            this.按钮提示.SetToolTip(this.button_ping网段, "ping该网段下的所有设备");
            this.button_ping网段.UseVisualStyleBackColor = true;
            this.button_ping网段.Click += new System.EventHandler(this.button_ping网段_Click);
            // 
            // textBox_ping
            // 
            this.textBox_ping.Location = new System.Drawing.Point(30, 54);
            this.textBox_ping.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_ping.Multiline = true;
            this.textBox_ping.Name = "textBox_ping";
            this.textBox_ping.Size = new System.Drawing.Size(216, 27);
            this.textBox_ping.TabIndex = 14;
            this.textBox_ping.Text = "/";
            this.textBox_ping.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 修改本机IP信息
            // 
            this.修改本机IP信息.Controls.Add(this.label1);
            this.修改本机IP信息.Controls.Add(this.textBox_ip文本框);
            this.修改本机IP信息.Controls.Add(this.textBox_子网掩码文本框);
            this.修改本机IP信息.Controls.Add(this.button_本机进程终结);
            this.修改本机IP信息.Controls.Add(this.textBox_网络名称文本框);
            this.修改本机IP信息.Controls.Add(this.textBox_本机端口);
            this.修改本机IP信息.Controls.Add(this.label2);
            this.修改本机IP信息.Controls.Add(this.button_本机端口检查);
            this.修改本机IP信息.Controls.Add(this.label3);
            this.修改本机IP信息.Controls.Add(this.label4);
            this.修改本机IP信息.Controls.Add(this.button_修改网络参数);
            this.修改本机IP信息.Controls.Add(this.checkBox_自动);
            this.修改本机IP信息.Location = new System.Drawing.Point(26, 513);
            this.修改本机IP信息.Name = "修改本机IP信息";
            this.修改本机IP信息.Size = new System.Drawing.Size(268, 462);
            this.修改本机IP信息.TabIndex = 34;
            this.修改本机IP信息.TabStop = false;
            this.修改本机IP信息.Text = "修改本机IP信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(92, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "网络名称";
            // 
            // textBox_ip文本框
            // 
            this.textBox_ip文本框.Location = new System.Drawing.Point(24, 130);
            this.textBox_ip文本框.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_ip文本框.Multiline = true;
            this.textBox_ip文本框.Name = "textBox_ip文本框";
            this.textBox_ip文本框.Size = new System.Drawing.Size(216, 27);
            this.textBox_ip文本框.TabIndex = 2;
            this.textBox_ip文本框.Text = "/";
            this.textBox_ip文本框.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_子网掩码文本框
            // 
            this.textBox_子网掩码文本框.Location = new System.Drawing.Point(24, 203);
            this.textBox_子网掩码文本框.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_子网掩码文本框.Multiline = true;
            this.textBox_子网掩码文本框.Name = "textBox_子网掩码文本框";
            this.textBox_子网掩码文本框.Size = new System.Drawing.Size(216, 27);
            this.textBox_子网掩码文本框.TabIndex = 2;
            this.textBox_子网掩码文本框.Text = "/";
            this.textBox_子网掩码文本框.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_网络名称文本框
            // 
            this.textBox_网络名称文本框.Location = new System.Drawing.Point(24, 57);
            this.textBox_网络名称文本框.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_网络名称文本框.Multiline = true;
            this.textBox_网络名称文本框.Name = "textBox_网络名称文本框";
            this.textBox_网络名称文本框.ReadOnly = true;
            this.textBox_网络名称文本框.Size = new System.Drawing.Size(216, 27);
            this.textBox_网络名称文本框.TabIndex = 5;
            this.textBox_网络名称文本框.TabStop = false;
            this.textBox_网络名称文本框.Text = "/";
            this.textBox_网络名称文本框.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(101, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "ip地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(92, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "子网掩码";
            // 
            // 探测外界IP
            // 
            this.探测外界IP.Controls.Add(this.label6);
            this.探测外界IP.Controls.Add(this.button_ping);
            this.探测外界IP.Controls.Add(this.textBox_ping);
            this.探测外界IP.Controls.Add(this.button_ping端口);
            this.探测外界IP.Controls.Add(this.button_ping网段);
            this.探测外界IP.Controls.Add(this.textBox_远方端口);
            this.探测外界IP.Controls.Add(this.textBox_网段内设备列表);
            this.探测外界IP.Controls.Add(this.label_日志文本);
            this.探测外界IP.Controls.Add(this.label7);
            this.探测外界IP.Location = new System.Drawing.Point(317, 513);
            this.探测外界IP.Name = "探测外界IP";
            this.探测外界IP.Size = new System.Drawing.Size(651, 462);
            this.探测外界IP.TabIndex = 36;
            this.探测外界IP.TabStop = false;
            this.探测外界IP.Text = "探测外界IP";
            // 
            // textBox_远方端口
            // 
            this.textBox_远方端口.Location = new System.Drawing.Point(30, 127);
            this.textBox_远方端口.Name = "textBox_远方端口";
            this.textBox_远方端口.Size = new System.Drawing.Size(102, 28);
            this.textBox_远方端口.TabIndex = 29;
            this.textBox_远方端口.Text = "/";
            this.textBox_远方端口.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_网段内设备列表
            // 
            this.textBox_网段内设备列表.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_网段内设备列表.Location = new System.Drawing.Point(30, 200);
            this.textBox_网段内设备列表.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_网段内设备列表.Multiline = true;
            this.textBox_网段内设备列表.Name = "textBox_网段内设备列表";
            this.textBox_网段内设备列表.ReadOnly = true;
            this.textBox_网段内设备列表.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_网段内设备列表.Size = new System.Drawing.Size(598, 227);
            this.textBox_网段内设备列表.TabIndex = 17;
            this.textBox_网段内设备列表.TabStop = false;
            this.textBox_网段内设备列表.Text = "///";
            this.textBox_网段内设备列表.WordWrap = false;
            // 
            // label_日志文本
            // 
            this.label_日志文本.AutoSize = true;
            this.label_日志文本.BackColor = System.Drawing.Color.Transparent;
            this.label_日志文本.ForeColor = System.Drawing.Color.Black;
            this.label_日志文本.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_日志文本.Location = new System.Drawing.Point(342, 33);
            this.label_日志文本.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_日志文本.Name = "label_日志文本";
            this.label_日志文本.Size = new System.Drawing.Size(44, 18);
            this.label_日志文本.TabIndex = 1;
            this.label_日志文本.Text = "----";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(98, 175);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ping结果";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(396, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 30);
            this.label5.TabIndex = 37;
            this.label5.Text = "本机网络调试";
            // 
            // 本机调试
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.显示本机IP信息);
            this.Controls.Add(this.修改本机IP信息);
            this.Controls.Add(this.探测外界IP);
            this.Name = "本机调试";
            this.Size = new System.Drawing.Size(1000, 1000);
            this.显示本机IP信息.ResumeLayout(false);
            this.修改本机IP信息.ResumeLayout(false);
            this.修改本机IP信息.PerformLayout();
            this.探测外界IP.ResumeLayout(false);
            this.探测外界IP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_ping;
        private System.Windows.Forms.ToolTip 按钮提示;
        private System.Windows.Forms.Button button_本机进程终结;
        private System.Windows.Forms.TextBox textBox_本机端口;
        private System.Windows.Forms.Button button_本机端口检查;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox 显示本机IP信息;
        private System.Windows.Forms.Button 刷新网络;
        private System.Windows.Forms.ListView listView_ip显示;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button_WL;
        private System.Windows.Forms.Button 注册刷新网络;
        private System.Windows.Forms.CheckBox checkBox_自动;
        private System.Windows.Forms.TextBox textBox_ping;
        private System.Windows.Forms.Button button_ping端口;
        private System.Windows.Forms.GroupBox 修改本机IP信息;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ip文本框;
        private System.Windows.Forms.TextBox textBox_子网掩码文本框;
        private System.Windows.Forms.TextBox textBox_网络名称文本框;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_修改网络参数;
        private System.Windows.Forms.GroupBox 探测外界IP;
        private System.Windows.Forms.Button button_ping网段;
        private System.Windows.Forms.TextBox textBox_远方端口;
        private System.Windows.Forms.TextBox textBox_网段内设备列表;
        private System.Windows.Forms.Label label_日志文本;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}
