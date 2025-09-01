
namespace 网络工具
{
    partial class 主页面
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(主页面));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OPCUA通信 = new System.Windows.Forms.Button();
            this.关于 = new System.Windows.Forms.Button();
            this.TCP_IP通信 = new System.Windows.Forms.Button();
            this.label_公告 = new System.Windows.Forms.Label();
            this.HTTP请求调试 = new System.Windows.Forms.Button();
            this.本机网络调试 = new System.Windows.Forms.Button();
            this.OPCUA通信_页面 = new 网络工具.OPCUA通信();
            this.本机调试_窗口 = new 网络工具.本机调试();
            this.HTTP调试_窗口 = new 网络工具.HTTP调试();
            this.关于页面_窗口 = new 网络工具.关于页面();
            this.TCP_IP通信_页面 = new 网络工具.TCP_IP通信();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.OPCUA通信);
            this.splitContainer1.Panel1.Controls.Add(this.关于);
            this.splitContainer1.Panel1.Controls.Add(this.TCP_IP通信);
            this.splitContainer1.Panel1.Controls.Add(this.label_公告);
            this.splitContainer1.Panel1.Controls.Add(this.HTTP请求调试);
            this.splitContainer1.Panel1.Controls.Add(this.本机网络调试);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.OPCUA通信_页面);
            this.splitContainer1.Panel2.Controls.Add(this.本机调试_窗口);
            this.splitContainer1.Panel2.Controls.Add(this.HTTP调试_窗口);
            this.splitContainer1.Panel2.Controls.Add(this.关于页面_窗口);
            this.splitContainer1.Panel2.Controls.Add(this.TCP_IP通信_页面);
            // 
            // OPCUA通信
            // 
            resources.ApplyResources(this.OPCUA通信, "OPCUA通信");
            this.OPCUA通信.Name = "OPCUA通信";
            this.OPCUA通信.UseVisualStyleBackColor = true;
            this.OPCUA通信.Click += new System.EventHandler(this.OPCUA通信_Click);
            // 
            // 关于
            // 
            resources.ApplyResources(this.关于, "关于");
            this.关于.Name = "关于";
            this.关于.UseVisualStyleBackColor = true;
            this.关于.Click += new System.EventHandler(this.关于_Click);
            // 
            // TCP_IP通信
            // 
            resources.ApplyResources(this.TCP_IP通信, "TCP_IP通信");
            this.TCP_IP通信.Name = "TCP_IP通信";
            this.TCP_IP通信.UseVisualStyleBackColor = true;
            this.TCP_IP通信.Click += new System.EventHandler(this.TCP_IP通信_Click);
            // 
            // label_公告
            // 
            resources.ApplyResources(this.label_公告, "label_公告");
            this.label_公告.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_公告.Name = "label_公告";
            // 
            // HTTP请求调试
            // 
            resources.ApplyResources(this.HTTP请求调试, "HTTP请求调试");
            this.HTTP请求调试.Name = "HTTP请求调试";
            this.HTTP请求调试.UseVisualStyleBackColor = true;
            this.HTTP请求调试.Click += new System.EventHandler(this.HTTP请求调试_Click);
            // 
            // 本机网络调试
            // 
            this.本机网络调试.BackColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.本机网络调试, "本机网络调试");
            this.本机网络调试.Name = "本机网络调试";
            this.本机网络调试.UseVisualStyleBackColor = false;
            this.本机网络调试.Click += new System.EventHandler(this.本机网络调试_Click);
            // 
            // OPCUA通信_页面
            // 
            resources.ApplyResources(this.OPCUA通信_页面, "OPCUA通信_页面");
            this.OPCUA通信_页面.Name = "OPCUA通信_页面";
            // 
            // 本机调试_窗口
            // 
            this.本机调试_窗口.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.本机调试_窗口, "本机调试_窗口");
            this.本机调试_窗口.Name = "本机调试_窗口";
            // 
            // HTTP调试_窗口
            // 
            this.HTTP调试_窗口.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.HTTP调试_窗口, "HTTP调试_窗口");
            this.HTTP调试_窗口.Name = "HTTP调试_窗口";
            // 
            // 关于页面_窗口
            // 
            resources.ApplyResources(this.关于页面_窗口, "关于页面_窗口");
            this.关于页面_窗口.Name = "关于页面_窗口";
            // 
            // TCP_IP通信_页面
            // 
            resources.ApplyResources(this.TCP_IP通信_页面, "TCP_IP通信_页面");
            this.TCP_IP通信_页面.Name = "TCP_IP通信_页面";
            // 
            // 主页面
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "主页面";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private 本机调试 本机调试_窗口;
        private System.Windows.Forms.Button HTTP请求调试;
        private System.Windows.Forms.Button 本机网络调试;
        private HTTP调试 HTTP调试_窗口;
        private System.Windows.Forms.Label label_公告;
        private System.Windows.Forms.Button TCP_IP通信;
        private System.Windows.Forms.Button 关于;
        private 关于页面 关于页面_窗口;
        private TCP_IP通信 TCP_IP通信_页面;
        private System.Windows.Forms.Button OPCUA通信;
        private OPCUA通信 OPCUA通信_页面;
    }
}

