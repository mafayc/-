using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace 网络工具
{
    public partial class HTTP调试 : UserControl
    {
        private static readonly HttpClient httpClient = new HttpClient();// 整个程序共用同一个 HttpClient
        public HTTP调试()
        {
            InitializeComponent();
        }








        private async void 发送_Click(object sender, EventArgs e)
        {

            状态栏_状态码.Text=状态栏_通信结果.Text = "正在请求...";
            发送请求.Enabled = false;            
            显示响应.Clear();

            try
            {
                string resp = await DoRequestAsync();
                显示响应.Text = resp;
                状态栏_通信结果.Text = "[完成]";
            }
            catch (Exception ex)
            {
                显示响应.Text = $"错误：{ex.Message}";
                状态栏_通信结果.Text = "[失败]";
            } finally
            {
                发送请求.Enabled = true;
            }
        }

        private async Task<string> DoRequestAsync()
        {
            var method = new HttpMethod(请求方法.SelectedItem.ToString());
            var request = new HttpRequestMessage(method, 目标URL.Text.Trim());

            // 处理请求头（每行 “Key: Value”）
            foreach (var line in 请求头.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries))
            {
                int idx = line.IndexOf(':');
                if (idx > 0)
                {
                    string key = line.Substring(0, idx).Trim();
                    string val = line.Substring(idx + 1).Trim();
                    if (!string.Equals(key, "Content-Type", StringComparison.OrdinalIgnoreCase))
                        request.Headers.TryAddWithoutValidation(key, val);
                }
            }

            // 处理请求体（POST/PUT/PATCH）
            if (method == HttpMethod.Post || method == HttpMethod.Put ||
                method == HttpMethod.Delete || method.Method.Equals("PATCH", StringComparison.OrdinalIgnoreCase))
            {
                string body = 请求体.Text;
                string contentType = "application/json";   // 默认
                // 如果用户在请求头里写了 Content-Type，就用他的
                foreach (var line in 请求头.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (line.StartsWith("Content-Type:", StringComparison.OrdinalIgnoreCase))
                    {
                        contentType = line.Substring(line.IndexOf(':') + 1).Trim();
                        break;
                    }
                }
                request.Content = new StringContent(body, Encoding.UTF8, contentType);
            }

            // 发送
            using (var response = await httpClient.SendAsync(request))
            {

                int statusCode = (int)response.StatusCode;   // ← 这里已经能拿到
                string reason = response.ReasonPhrase;      // 例如 "OK"、"Not Found"

                string body = await response.Content.ReadAsStringAsync();

                // 想单独显示
                状态栏_状态码.Text = statusCode.ToString();

                // 想一起返回
                return reason+body;
                //string body = await response.Content.ReadAsStringAsync();
                //return $"HTTP {(int)response.StatusCode} {response.StatusCode}\r\n\r\n{body}";
            }
        }

        private void 请求方法_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tips = new System.Collections.Generic.Dictionary<string, string>
            {
                ["GET"]    = "GET：只读获取数据，最安全",
                ["POST"]   = "POST：新建或提交资源",
                ["PUT"]    = "PUT：整体替换资源",
                ["DELETE"] = "DELETE：删除指定资源",
                ["PATCH"]  = "PATCH：局部更新字段",
                ["OPTIONS"]= "OPTIONS：查询服务器支持的方法",
                ["HEAD"]   = "HEAD：只拿响应头，不拿正文"
            };

            if (请求方法.SelectedItem != null && tips.TryGetValue(请求方法.SelectedItem.ToString(), out var msg))
            {
                状态栏_帮助.Text= msg;
            }
        }

        private void 目标URL_帮助(object sender, MouseEventArgs e)
        {
            状态栏_帮助.Text="目标 URL：你想访问那个网址";
        }

        private void 请求头_帮助(object sender, MouseEventArgs e)
        {
            状态栏_帮助.Text="请求头：说明客户端身份、期望格式等信息";
        }

        private void 请求体_帮助(object sender, MouseEventArgs e)
        {
            状态栏_帮助.Text="请求体：发送给服务器的“具体内容”";
        }

        private void 显示响应_帮助(object sender, MouseEventArgs e)
        {
            状态栏_帮助.Text="显示响应：服务器返回的“具体内容”";
        }
    }
}
