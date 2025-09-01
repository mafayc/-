using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 网络工具
{
    public partial class 关于页面 : UserControl
    {
        public 关于页面()
        {
            InitializeComponent();
            关于信息.Text = "《网络工具》版本号: "+                Application.ProductVersion+
                            "\r\n          个人开发工具，仅学习交流。"+
                            "\r\n          联系邮箱：1961742007@QQ.COM" +                            
                            "\r\n© 2021 源 " +
                            "\r\n版权所有";
        }
    }
}
