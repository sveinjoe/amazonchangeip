using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Security.Cryptography;
using System.Net;
using System.IO;
using System.Net.Security;
using System.Diagnostics;

namespace 亚马逊换ip工具
{
    public partial class Form1 : Form
    {
        private static bool CheckValidationResult(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, SslPolicyErrors errors)
        {
            return true; //总是接受     
        }
        private string filenameConfig = Application.StartupPath + "\\config.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //密码验证
            string passwd = Interaction.InputBox("请输入密码", "密码", "请输入密码", -1, -1);
            string datenow = DateTime.Now.ToString("yyyyMMddHH"); //获取当前时间到小时
            if (passwd.Equals(string.Empty) == false)
            {
                string passstr = passwd + ":" + datenow;
                string remotemd5 = GetHtml("http://www.sveinjoe.top/validate.php?pass=" + passwd, "");
                string localmd5 = getMD5(passstr);
                if (remotemd5.Equals(localmd5) == false)
                {
                    MessageBox.Show("验证成功！");
                    this.Close(); //验证失败，关闭
                }
            }
            else
            {
                this.Close();
            }
            //验证成功
            //读取配置文件
            if (File.Exists(filenameConfig))
            {
                string[] arrConfig = File.ReadAllLines(filenameConfig);
                if (arrConfig.Length == 6)
                {
                    textBoxADSLName.Text = arrConfig[0];
                    textBoxADSLAccount.Text = arrConfig[1];
                    textBoxADSLPass.Text = arrConfig[2];
                    textBoxTimerInterval.Text = arrConfig[3];
                    textBoxURI.Text = arrConfig[4];
                    textBoxErrorStr.Text = arrConfig[5];
                }
            }
        }
        private string GetHtml(string url)
        {
            return GetHtml(url, "");
        }

        public string GetHtml(string url, string proxy)
        {
            string html = "";
            try
            {
                HttpWebRequest request = null;
                //HTTPSQ请求
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                request = WebRequest.Create(url) as HttpWebRequest;
                if (proxy.Equals(string.Empty) == false)
                {
                    //检测是否使用代理
                    WebProxy proxy1 = new WebProxy(proxy);
                    request.Proxy = proxy1;
                }
                request.ProtocolVersion = HttpVersion.Version11;
                request.Method = "GET";
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) 1 Chrome/57.0.2987.133 Safari/537.36";
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                html = sr.ReadToEnd();
            }

            catch (System.Exception ex)
            {

                string errorMsg = ex.Message;
                html = errorMsg;
            }

            return html;

        }

        private string getMD5(string str)
        {
            string returnstr = "";
            byte[] result = Encoding.Default.GetBytes(str.Trim());
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            returnstr = BitConverter.ToString(output).Replace("-", "");
            return returnstr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxADSLAccount.Text.Equals(string.Empty))
            {
                MessageBox.Show("宽带欠费了吗？");
                textBoxADSLAccount.BackColor = Color.Red;
                return;
            }
            if (textBoxADSLPass.Text.Equals(string.Empty))
            {
                MessageBox.Show("宽带欠费了吗？");
                textBoxADSLPass.BackColor = Color.Red;
                return;
            }
            if (textBoxADSLName.Text.Equals(string.Empty))
            {
                MessageBox.Show("宽带名称的意思就是查看网络和共享中心，你用来拨号的那个宽带连接的图标的名字是什么？");
                textBoxADSLPass.BackColor = Color.Red;
                return;
            }
            //开始
            int TimerInterval = 0;
            int.TryParse(textBoxTimerInterval.Text, out TimerInterval); //设置线程
            timer1.Interval = TimerInterval;
            //保存当前设置
            string[] arrConfig = new string[6];
            arrConfig[0] = textBoxADSLName.Text;
            arrConfig[1] += textBoxADSLAccount.Text;
            arrConfig[2] += textBoxADSLPass.Text;
            arrConfig[3] += textBoxTimerInterval.Text;
            arrConfig[4] += textBoxURI.Text;
            arrConfig[5] += textBoxErrorStr.Text;
            File.WriteAllLines(filenameConfig, arrConfig); 
            startCheck();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startCheck();
        }

        private void startCheck()
        {
            timer1.Start();
            //拉取amazon.com的网页内容
            labelResult.Text = "上次执行时间为：" + DateTime.Now.ToString();
            string content = GetHtml(textBoxURI.Text);
            if (content.IndexOf(textBoxErrorStr.Text) > 0)
            {
                ChangeIp();
            }
        }

        /// <summary>
        /// 开始拨号
        /// </summary>
        /// <param name="ADSL_Name">宽带连接名称</param>
        /// <param name="ADSL_UserName">宽带连接用户名</param>
        /// <param name="ADSL_PassWord">宽带连接密码</param>
        private void ChangeIp()
        {
            StringBuilder sb = new StringBuilder();
            sb.Clear();
            sb.AppendLine("@echo off");
            sb.AppendLine("set adslmingzi=" + textBoxADSLName.Text);
            sb.AppendLine("set adslzhanghao=" + textBoxADSLAccount.Text);
            sb.AppendLine("set adslmima=" + textBoxADSLPass.Text);
            sb.AppendLine("@Rasdial %adslmingzi% /disconnect");
            sb.AppendLine("ping 127.0.0.1 -n 2 > nul");
            sb.AppendLine("Rasdial %adslmingzi% %adslzhanghao% %adslmima%");
            sb.AppendLine("echo 连接中");
            sb.AppendLine("ping 127.0.0.1 -n 4 > nul");
            string temppath = Application.StartupPath + "\\temp.bat";
            using (StreamWriter sw = new StreamWriter(temppath, false, Encoding.Default))
            {
                sw.Write(sb.ToString());
            }
            Process.Start(temppath);
            int delay = 10;
            System.Threading.Thread.Sleep(delay * 1000);
            //File.Delete(temppath);
        }
    }
}
