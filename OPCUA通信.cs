using System;
using System.Windows.Forms;
using OpcUaHelper.Forms;   // NuGet: OpcUaHelper

namespace 网络工具
{
    public partial class OPCUA通信 : UserControl
    {
        private FormBrowseServer _browser;   // 浏览窗口实例

        public OPCUA通信()
        {
            InitializeComponent();
            打开();
        }

        /* ========== 打开 ========== */
        private void 打开_Click(object sender, EventArgs e)
        {
            打开();
        }

        private void 打开()
        {
            // 若已存在但未释放，直接显示；否则重新创建
            if (_browser == null || _browser.IsDisposed)
            {
                _browser = new FormBrowseServer
                {
                    TopLevel     = false,            // 关键：作为子控件
                    FormBorderStyle = FormBorderStyle.None,
                    ControlBox   = false,
                    MaximizeBox  = false,
                    MinimizeBox  = false,
                    Dock         = DockStyle.Fill    // 填满 Panel
                };

                显示.Controls.Add(_browser);        // 塞进 Panel
            }

            _browser.Show();            // 显示
            _browser.BringToFront();    // 确保在最前
        }



    }
}