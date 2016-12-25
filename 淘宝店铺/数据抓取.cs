using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace 淘宝店铺
{
    public class 数据抓取
    {
        string url = "";
        string page = "";
        int searchindex = 1;
        Dictionary<string, string> rank = new Dictionary<string, string>();

        public event EventHandler<SendResultEventArgs> SendResult;
        SendResultEventArgs result = new SendResultEventArgs();

        public 数据抓取(string url)
        {
            this.url = url;
            rank.Add("rank seller-rank-0", "");
            rank.Add("rank seller-rank-1", "一星");
            rank.Add("rank seller-rank-2", "二星");
            rank.Add("rank seller-rank-3", "三星");
            rank.Add("rank seller-rank-4", "四星");
            rank.Add("rank seller-rank-5", "五星");
            rank.Add("rank seller-rank-6", "一钻");
            rank.Add("rank seller-rank-7", "二钻");
            rank.Add("rank seller-rank-8", "三钻");
            rank.Add("rank seller-rank-9", "四钻");
            rank.Add("rank seller-rank-10", "五钻");
            rank.Add("rank seller-rank-11", "一皇冠");
            rank.Add("rank seller-rank-12", "二皇冠");
            rank.Add("rank seller-rank-13", "三皇冠");
            rank.Add("rank seller-rank-14", "四皇冠");
            rank.Add("rank seller-rank-15", "五皇冠");
            rank.Add("rank seller-rank-16", "一金冠");
            rank.Add("rank seller-rank-17", "二金冠");
            rank.Add("rank seller-rank-18", "三金冠");
            rank.Add("rank seller-rank-19", "四金冠");
            rank.Add("rank seller-rank-20", "五金冠");
        }

        /*
         抓取网站数据
         传入页面地址和回调函数
         返回符合条件的数据集
         */

        public List<店铺数据> 抓取()
        {
            List<店铺数据> datas = new List<店铺数据>();
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document = web.Load(this.url + this.page);

            var str = document.DocumentNode.SelectNodes("//html//head//script[6]")[0].InnerText.Split(Environment.NewLine.ToCharArray())[2].Replace("g_page_config = ", "").TrimStart().TrimEnd(';');

            var v = JsonConvert.DeserializeObject<网站数据Json>(str);

            //销量<4 并且是淘宝店铺
            v.mods.shoplist.data.shopItems.ForEach(item => {
                if(item.totalsold < 4 && !item.isTmall)
                {
                    datas.Add(new 店铺数据 {
                        商品数量 = item.procnt,
                        店铺名称 = item.title,
                        店铺地址 = "https:" + item.shopUrl,
                        旺旺名称 = item.nick,
                        是否在线 = "待检测",
                        等级 = rank[item.shopIcon.iconClass],
                        销量 = item.totalsold,
                        ShopID = item.uid
                    });
                }
                OnSend(new SendResultEventArgs { totalCount = v.mods.pager.data.totalCount, current = searchindex });
                searchindex++;
            });

            if(v.mods.pager.data.currentPage < v.mods.pager.data.totalPage)
            {
                this.page = "&s=" + (v.mods.pager.data.pageSize * v.mods.pager.data.currentPage);
                var d = 抓取();
                datas.AddRange(d.ToArray());
            }

            return datas;
        }

        protected virtual void OnSend(SendResultEventArgs e)
        {
            EventHandler<SendResultEventArgs> handler = SendResult;
            if (handler != null)
            {
                handler(this, e);//触发回调函数
            }
        }
    }
}
