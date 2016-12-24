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
    public partial class FormMain : Form
    {
        List<店铺数据> datas = new List<店铺数据>();

        public FormMain()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("请先输入关键词");
                return;
            }

            button1.Enabled = false;
            Thread t = new Thread(T);
            t.Start();
        }

        private void T()
        {
            string url = string.Format("https://shopsearch.taobao.com/search?app=shopsearch&q={0}", System.Web.HttpUtility.UrlEncode(textBox1.Text));
            数据抓取 f = new 数据抓取(url);
            f.SendResult += F_SendResult;
            datas = f.抓取();
            CheckContact();
        }

        private void BindData()
        {
            if (chkContact.Checked)
                店铺数据BindingSource.DataSource = datas.Where(a => string.IsNullOrEmpty(a.联系时间));
            else
                店铺数据BindingSource.DataSource = datas;

            dataGridView1.Refresh();
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

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                textBox1.Text = textBox1.Tag.ToString().Trim();
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox1.Tag.ToString())
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// 检查是否联系过
        /// </summary>
        private void CheckContact()
        {
            List<string> shopIds = new List<string>();

            if (datas.Count <= 100)
            {
                shopIds = datas.Select(s => s.ShopID).ToList();
                var res = Tool.service.CheckContacts(shopIds.ToArray());
                var dic = JsonConvert.DeserializeObject<Dictionary<string, string>>(res);

                foreach (var d in dic)
                {
                    datas.First(a => a.ShopID == d.Key).联系时间 = d.Value;
                }
            }
            else
            {
                List<店铺数据> copy = new List<店铺数据>(datas.ToArray());
                while (copy.Count > 0)
                {
                    shopIds = copy.Take(100).Select(s => s.ShopID).ToList();
                    copy.RemoveRange(0, 100);

                    var res = Tool.service.CheckContacts(shopIds.ToArray());
                    var dic = JsonConvert.DeserializeObject<Dictionary<string, string>>(res);

                    foreach (var d in dic)
                    {
                        datas.First(a => a.ShopID == d.Key).联系时间 = d.Value;
                    }
                }
            }

            BindData();
        }        

        private void CheckContact(string shopId)
        {
            var res = Tool.service.CheckContact(shopId);
        }

        private void chkContact_CheckedChanged(object sender, EventArgs e)
        {
            BindData();
        }

        private void chkLine_CheckedChanged(object sender, EventArgs e)
        {
            if(datas.Count > 0)
            {
                CheckOnLine();
                timer1.Enabled = true;
            }
        }

        /// <summary>
        /// 检查是否在线
        /// </summary>
        private void CheckOnLine()
        {
            var url = "http://amos.alicdn.com/muliuserstatus.aw?beginnum=0&site=cntaobao&charset=utf-8&uids={0}&callback=jsonp";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            var names = string.Join(";", datas.Select(s => s.旺旺名称).ToArray());
            document = web.Load(string.Format(url, names));
            var json = document.DocumentNode.InnerText.Replace("jsonp(", "").Replace(")", "");
            var v = JsonConvert.DeserializeObject<JsonData>(json);
            for (int i = 0; i < datas.Count; i++)
            {
                datas[i].是否在线 = v.data[i] == 1 ? "是" : "否";
            }

            BindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckOnLine();
        }

        public class JsonData
        {
            public bool success { get; set; }
            public int[] data { get; set; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            CheckOnLine();

            timer1.Enabled = chkLine.Checked;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var ww = 旺旺地址DataGridViewTextBoxColumn.Index;
            var dp = 店铺地址DataGridViewTextBoxColumn.Index;

            if (e.ColumnIndex == ww || e.ColumnIndex == dp)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                if(e.ColumnIndex == ww)
                {
                    var shopid = row.Cells[colShopID.Name].Value.ToString();
                    var str = Tool.service.AddContact(shopid, UserInfo.UserName);
                    var res = JsonConvert.DeserializeObject<Model.Result>(str);
                    if (!res.Succeed && res.Message == "已经联系过")
                    {
                        if (MessageBox.Show("已经联系过,是否继续联系", "提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                            return;
                    }
                    else
                    {
                        datas.Where(a => a.ShopID == shopid).First().联系时间 = DateTime.Now.ToString();
                        dataGridView1.Refresh();
                    }
                }
                
                System.Diagnostics.Process.Start(row.Cells[e.ColumnIndex].Value.ToString());
            }
        }
    }
}
