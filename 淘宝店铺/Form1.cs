using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading;

namespace 淘宝店铺
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Thread t = new Thread(T);
            t.Start();
        }

        private void T()
        {
            string url = string.Format("https://shopsearch.taobao.com/search?app=shopsearch&q={0}", System.Web.HttpUtility.UrlEncode("威舞"));
            数据抓取 f = new 数据抓取(url);
            f.SendResult += F_SendResult;
            var datas = f.抓取();
        }

        private void F_SendResult(object sender, SendResultEventArgs e)
        {
            this.Invoke(new Action(() => {
                label1.Text = e.ToString();
                progressBar1.Maximum = e.totalCount;
                progressBar1.Value = e.current;
                button1.Enabled = e.isok;
            }));
        }
    }

    
}
