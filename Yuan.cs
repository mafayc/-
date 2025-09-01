using System;
using System.Windows.Forms;


namespace 网络工具
{
    public partial class 主页面 : Form
    {   

        public 主页面()
        {
            InitializeComponent();
            label_公告.Text = "版本号: \n"+Application.ProductVersion;
        }



        private void 本机网络调试_Click(object sender, EventArgs e)
        {
            切换页面(本机网络调试,本机调试_窗口);

        }

        private void HTTP请求调试_Click(object sender, EventArgs e)
        {
            切换页面(HTTP请求调试,HTTP调试_窗口);
         }
        private void 关于_Click(object sender, EventArgs e)
        {
            切换页面(关于, 关于页面_窗口);
        }

        private void TCP_IP通信_Click(object sender, EventArgs e)
        {
            切换页面(TCP_IP通信, TCP_IP通信_页面);
        }

        //══════════════════════════ 功能实现 ══════════════════════════



        private void 切换页面(Button 变色按钮,Control  name)
        {
            //更改导航栏按钮颜色
            TCP_IP通信.BackColor=关于.BackColor=HTTP请求调试.BackColor=本机网络调试.BackColor=System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            变色按钮.BackColor=System.Drawing.ColorTranslator.FromHtml("#56baed");

            //更改页面显示
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(name);


        }


    }
}