using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading;

namespace 淘宝店铺
{
    public partial class FormMain : Form
    {
        //List<店铺数据> datas = new List<店铺数据>();

        public FormMain()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            button2.Visible = UserInfo.IsAdmin;

#if DEBUG
            textBox1.Text = "威舞";
#endif
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == textBox1.Tag.ToString())
            {
                MessageBox.Show("请先输入关键词");
                return;
            }
            if(dataGridView1.Rows.Count > 0)
            {
                if (MessageBox.Show("现在抓取将覆盖当前的数据，不可恢复，是否继续", "提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    return;
            }
            //datas.Clear();
            dataGridView1.Rows.Clear();

            button1.Enabled = false;
            groupBox1.Enabled = false;
            Thread t = new Thread(T);
            t.Start();
        }

        private void T()
        {
            string url = string.Format("https://shopsearch.taobao.com/search?app=shopsearch&q={0}", System.Web.HttpUtility.UrlEncode(textBox1.Text));
            数据抓取 f = new 数据抓取(url);
            f.SendResult += F_SendResult;
            f.抓取();            
            this.Invoke(new Action(() => {
                button1.Enabled = true;
                groupBox1.Enabled = true;
                label1.Text = "抓取完成";
                progressBar1.Value = progressBar1.Maximum;
                CheckContact();
            }));
        }

        //private void BindData()
        //{
        //    if (chkContact.Checked)
        //        dataGridView1.DataSource = datas.Where(a => string.IsNullOrEmpty(a.联系时间));
        //    else
        //        dataGridView1.DataSource = datas;
        //    dataGridView1.Refresh();
        //}

        private void F_SendResult(object sender, SendResultEventArgs e)
        {
            this.Invoke(new Action(() => {
                label1.Text = e.ToString();
                progressBar1.Maximum = e.totalCount;
                progressBar1.Value = e.current;
                button1.Enabled = e.isok;
                groupBox1.Enabled = e.isok;
                if (e.data != null)
                {
                    //datas.Add(e.data);
                    //if (dataGridView1.DataSource == null)
                    //{
                    //    dataGridView1.DataSource = datas;
                    //}
                    //else
                    //{
                    //    dataGridView1.DataSource = datas;
                    //    dataGridView1.Refresh();
                    //}

                    string[] row = { e.data.ShopID, e.data.店铺名称, e.data.等级, e.data.商品数量.ToString(), e.data.销量.ToString(), e.data.是否在线, e.data.联系时间, e.data.店铺地址, e.data.旺旺名称, e.data.旺旺地址 };
                    dataGridView1.Rows.Add(row);

                    //var i = dataGridView1.Rows.Add();
                    //dataGridView1.Rows[i].Cells[col商品数量.Name].Value = e.data.商品数量.ToString();
                    //dataGridView1.Rows[i].Cells[colShopID.Name].Value = e.data.ShopID;
                    //dataGridView1.Rows[i].Cells[col店铺名称.Name].Value = e.data.店铺名称;
                    //dataGridView1.Rows[i].Cells[col店铺地址.Name].Value = e.data.店铺地址;
                    //dataGridView1.Rows[i].Cells[col旺旺名称.Name].Value = e.data.旺旺名称;
                    //dataGridView1.Rows[i].Cells[col旺旺地址.Name].Value = e.data.旺旺地址;
                    //dataGridView1.Rows[i].Cells[col是否在线.Name].Value = e.data.是否在线;
                    //dataGridView1.Rows[i].Cells[col等级.Name].Value = e.data.等级;
                    //dataGridView1.Rows[i].Cells[col联系时间.Name].Value = e.data.联系时间;
                    //dataGridView1.Rows[i].Cells[col销量.Name].Value = e.data.销量.ToString();
                }
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
            int count = 100;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var id = dataGridView1.Rows[i].Cells[colShopID.Name].Value.ToString();
                shopIds.Add(id);

                if (shopIds.Count == count || i == dataGridView1.Rows.Count - 1)
                {
                    var res = Tool.service.CheckContacts(shopIds.ToArray());
                    var dic = JsonConvert.DeserializeObject<Dictionary<string, string>>(res);

                    foreach (var d in dic)
                    {
                        for (int j = 0; j < dataGridView1.Rows.Count; j++)
                        {
                            id = dataGridView1.Rows[j].Cells[colShopID.Name].Value.ToString();
                            if (id == d.Key)
                            {
                                dataGridView1.Rows[j].Cells[col联系时间.Name].Value = d.Value;
                            }
                        }
                    }
                    shopIds.Clear();
                }
            }

            //List<店铺数据> copy = new List<店铺数据>(datas.ToArray());
            //while (copy.Count > 0)
            //{
            //    shopIds = copy.Take(count).Select(s => s.ShopID).ToList();
            //    copy.RemoveRange(0, copy.Count > count ? count : copy.Count);

            //    var res = Tool.service.CheckContacts(shopIds.ToArray());
            //    var dic = JsonConvert.DeserializeObject<Dictionary<string, string>>(res);

            //    foreach (var d in dic)
            //    {
            //        datas.First(a => a.ShopID == d.Key).联系时间 = d.Value;
            //    }
            //}
            //BindData();
            //dataGridView1.Refresh();
        }      

        private void CheckContact(string shopId)
        {
            var res = Tool.service.CheckContact(shopId);
        }

        private void chkContact_CheckedChanged(object sender, EventArgs e)
        {
            //BindData();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var time = dataGridView1.Rows[i].Cells[col联系时间.Name].Value.ToString();
                if(!string.IsNullOrWhiteSpace(time))
                {
                    dataGridView1.Rows[i].Visible = !chkContact.Checked;
                }
            }
        }

        private void chkLine_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && chkLine.Checked)
            {
                CheckOnLine();
                int interval = 0;
                if (!int.TryParse(textBox2.Text, out interval))
                    interval = 30;
                timer1.Interval = interval * 1000;
                timer1.Enabled = true;
            }
        }

        /// <summary>
        /// 检查是否在线
        /// </summary>
        private void CheckOnLine()
        {
            //List<店铺数据> copy = new List<店铺数据>(datas.ToArray());
            int count = 10;
            var url = "http://amos.alicdn.com/muliuserstatus.aw?beginnum=0&site=cntaobao&charset=utf-8&uids={0}&callback=jsonp";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            int index = 0;
            List<string> names = new List<string>();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var name = dataGridView1.Rows[i].Cells[col旺旺名称.Name].Value.ToString();
                names.Add(name);

                if (names.Count == count || i == dataGridView1.Rows.Count - 1)
                {
                    document = web.Load(string.Format(url, string.Join(";", names)));
                    var json = document.DocumentNode.InnerText.Replace("jsonp(", "").Replace(")", "");
                    var v = JsonConvert.DeserializeObject<JsonData>(json);
                    for (int j = 0; j < v.data.Length; j++)
                    {
                        dataGridView1.Rows[index++].Cells[col是否在线.Name].Value = v.data[j] == 1 ? "是" : "否";
                    }
                    names.Clear();
                }
            }

            //while (copy.Count > 0)
            //{
            //    var names = string.Join(";", copy.Take(count).Select(s => s.旺旺名称).ToArray());
            //    copy.RemoveRange(0, copy.Count > count ? count : copy.Count);

            //    document = web.Load(string.Format(url, names));

            //    var json = document.DocumentNode.InnerText.Replace("jsonp(", "").Replace(")", "");
            //    var v = JsonConvert.DeserializeObject<JsonData>(json);
            //    for (int i = 0; i < v.data.Length; i++)
            //    {
            //        datas[index++].是否在线 = v.data[i] == 1 ? "是" : "否";
            //    }
            //}
            //BindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormUserList().ShowDialog();
        }

        public class JsonData
        {
            public bool success { get; set; }
            public int[] data { get; set; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int interval = 0;
            if (!int.TryParse(textBox2.Text, out interval))
                interval = 30;
            timer1.Interval = interval * 1000;
            timer1.Enabled = false;
            CheckOnLine();

            timer1.Enabled = chkLine.Checked;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            var ww = col旺旺地址.Index;
            var dp = col店铺地址.Index;

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
                        row.Cells[col联系时间.Name].Value = DateTime.Now.ToString();
                        //datas.Where(a => a.ShopID == shopid).First().联系时间 = DateTime.Now.ToString();
                        //dataGridView1.Refresh();
                    }
                }
                
                System.Diagnostics.Process.Start(row.Cells[e.ColumnIndex].Value.ToString());
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "")
            {
                textBox2.Text = textBox2.Tag.ToString().Trim();
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox2.Tag.ToString())
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }
    }
}
