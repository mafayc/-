
namespace 网络工具
{
    partial class OPCUA通信
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
            this.显示 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(353, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 30);
            this.label6.TabIndex = 29;
            this.label6.Text = "打开OPC UA通信助手";
            this.label6.Click += new System.EventHandler(this.打开_Click);
            // 
            // 显示
            // 
            this.显示.Location = new System.Drawing.Point(25, 140);
            this.显示.Name = "显示";
            this.显示.Size = new System.Drawing.Size(950, 800);
            this.显示.TabIndex = 30;
            // 
            // OPCUA通信
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.显示);
            this.Controls.Add(this.label6);
            this.Name = "OPCUA通信";
            this.Size = new System.Drawing.Size(1000, 1000);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel 显示;
    }
}
