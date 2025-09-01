
namespace 网络工具
{
    partial class HTTP调试
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.显示响应 = new System.Windows.Forms.TextBox();
            this.发送请求 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.请求体 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.请求头 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.请求方法 = new System.Windows.Forms.ComboBox();
            this.目标URL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.状态栏 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.状态栏_通信结果 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.状态栏_状态码 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.状态栏_帮助 = new System.Windows.Forms.ToolStripStatusLabel();
            this.状态栏.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(396, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 30);
            this.label6.TabIndex = 25;
            this.label6.Text = "HTTP请求发起";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(38, 639);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "显示响应：";
            // 
            // 显示响应
            // 
            this.显示响应.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.显示响应.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.显示响应.Location = new System.Drawing.Point(41, 660);
            this.显示响应.Multiline = true;
            this.显示响应.Name = "显示响应";
            this.显示响应.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.显示响应.Size = new System.Drawing.Size(919, 304);
            this.显示响应.TabIndex = 22;
            this.显示响应.MouseClick += new System.Windows.Forms.MouseEventHandler(this.显示响应_帮助);
            // 
            // 发送请求
            // 
            this.发送请求.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.发送请求.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.发送请求.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.发送请求.Location = new System.Drawing.Point(657, 157);
            this.发送请求.Name = "发送请求";
            this.发送请求.Size = new System.Drawing.Size(303, 48);
            this.发送请求.TabIndex = 21;
            this.发送请求.Text = ">>>发送请求<<<";
            this.发送请求.UseVisualStyleBackColor = false;
            this.发送请求.Click += new System.EventHandler(this.发送_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(38, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "请求体：";
            // 
            // 请求体
            // 
            this.请求体.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.请求体.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.请求体.Location = new System.Drawing.Point(41, 519);
            this.请求体.Multiline = true;
            this.请求体.Name = "请求体";
            this.请求体.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.请求体.Size = new System.Drawing.Size(919, 94);
            this.请求体.TabIndex = 19;
            this.请求体.MouseClick += new System.Windows.Forms.MouseEventHandler(this.请求体_帮助);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(38, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "请求头：";
            // 
            // 请求头
            // 
            this.请求头.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.请求头.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.请求头.Location = new System.Drawing.Point(41, 378);
            this.请求头.Multiline = true;
            this.请求头.Name = "请求头";
            this.请求头.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.请求头.Size = new System.Drawing.Size(919, 94);
            this.请求头.TabIndex = 17;
            this.请求头.Text = "Accept: application/json";
            this.请求头.MouseClick += new System.Windows.Forms.MouseEventHandler(this.请求头_帮助);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(38, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "请求方法：";
            // 
            // 请求方法
            // 
            this.请求方法.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.请求方法.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.请求方法.FormattingEnabled = true;
            this.请求方法.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE",
            "PATCH",
            "OPTIONS",
            "HEAD"});
            this.请求方法.Location = new System.Drawing.Point(133, 166);
            this.请求方法.Name = "请求方法";
            this.请求方法.Size = new System.Drawing.Size(95, 26);
            this.请求方法.TabIndex = 15;
            this.请求方法.Text = "HEAD";
            this.请求方法.SelectedIndexChanged += new System.EventHandler(this.请求方法_SelectedIndexChanged);
            // 
            // 目标URL
            // 
            this.目标URL.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.目标URL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.目标URL.Location = new System.Drawing.Point(41, 237);
            this.目标URL.Multiline = true;
            this.目标URL.Name = "目标URL";
            this.目标URL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.目标URL.Size = new System.Drawing.Size(919, 60);
            this.目标URL.TabIndex = 14;
            this.目标URL.Text = "http://mafayuan.cn/";
            this.目标URL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.目标URL_帮助);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(38, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "目标URL：";
            // 
            // 状态栏
            // 
            this.状态栏.BackColor = System.Drawing.SystemColors.HotTrack;
            this.状态栏.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.状态栏.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.状态栏.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.状态栏_通信结果,
            this.toolStripStatusLabel2,
            this.状态栏_状态码,
            this.toolStripStatusLabel3,
            this.状态栏_帮助});
            this.状态栏.Location = new System.Drawing.Point(0, 968);
            this.状态栏.Name = "状态栏";
            this.状态栏.Size = new System.Drawing.Size(1000, 32);
            this.状态栏.TabIndex = 26;
            this.状态栏.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(138, 25);
            this.toolStripStatusLabel1.Text = "本次通信结果：";
            // 
            // 状态栏_通信结果
            // 
            this.状态栏_通信结果.Name = "状态栏_通信结果";
            this.状态栏_通信结果.Size = new System.Drawing.Size(30, 25);
            this.状态栏_通信结果.Text = "//";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(124, 25);
            this.toolStripStatusLabel2.Text = "        状态码：";
            // 
            // 状态栏_状态码
            // 
            this.状态栏_状态码.Name = "状态栏_状态码";
            this.状态栏_状态码.Size = new System.Drawing.Size(30, 25);
            this.状态栏_状态码.Text = "//";
            this.状态栏_状态码.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(633, 25);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = "帮助：";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 状态栏_帮助
            // 
            this.状态栏_帮助.Name = "状态栏_帮助";
            this.状态栏_帮助.Size = new System.Drawing.Size(30, 25);
            this.状态栏_帮助.Text = "//";
            // 
            // HTTP调试
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.状态栏);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.请求方法);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.显示响应);
            this.Controls.Add(this.发送请求);
            this.Controls.Add(this.请求体);
            this.Controls.Add(this.请求头);
            this.Controls.Add(this.目标URL);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "HTTP调试";
            this.Size = new System.Drawing.Size(1000, 1000);
            this.状态栏.ResumeLayout(false);
            this.状态栏.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox 显示响应;
        private System.Windows.Forms.Button 发送请求;

        private System.Windows.Forms.TextBox 请求体;
        
        private System.Windows.Forms.TextBox 请求头;
        
        private System.Windows.Forms.ComboBox 请求方法;
        private System.Windows.Forms.TextBox 目标URL;
        
        private System.Windows.Forms.StatusStrip 状态栏;
        private System.Windows.Forms.ToolStripStatusLabel 状态栏_通信结果;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel 状态栏_状态码;
        private System.Windows.Forms.ToolStripStatusLabel 状态栏_帮助;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}
