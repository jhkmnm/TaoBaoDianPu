using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 淘宝店铺
{
    public class 店铺数据
    {
        public string 店铺名称 { get; set; }

        public string 等级 { get; set; }

        public int 商品数量 { get; set; }

        public int 销量 { get; set; }

        public string 是否在线 { get; set; }

        public string 联系时间 { get; set; }

        public string 店铺地址 { get; set; }

        public string 旺旺名称 { get; set; }

        public string 旺旺地址 { get { return string.Format("https://amos.alicdn.com/getcid.aw?groupid=0&charset=utf-8&uid={0}&site=cntaobao", System.Web.HttpUtility.UrlEncode(旺旺名称)); } }
    }

    #region Json数据
    public class 网站数据Json
    {
        public string pageName { get; set; }
        public Mods mods { get; set; }
    }

    public class PagerData
    {
        public int pageSize { get; set; }
        public int totalPage { get; set; }
        public int currentPage { get; set; }
        public int totalCount { get; set; }
    }

    public class Pager
    {
        public string status { get; set; }
        public bool export { get; set; }
        public PagerData data { get; set; }
    }

    public class FeedBack
    {
        public string status { get; set; }
        public FeedBackData data { get; set; }
        public bool export { get; set; }
    }

    public class FeedBackData
    {
        public bool render { get; set; }
        public bool useOld { get; set; }
        public string showType { get; set; }
    }

    public class StatusData
    {
        public string status { get; set; }
        public bool export { get; set; }
    }

    public class P4P
    {
        public string status { get; set; }
        public P4PData data { get; set; }
        public bool export { get; set; }
    }

    public class P4PData
    {
        public string keyword { get; set; }
        public int pageNum { get; set; }
        public string frontcatid { get; set; }
        public int total { get; set; }
        public string keywordGBK { get; set; }
    }

    public class Mods
    {
        public Pager pager { get; set; }
        public FeedBack feedback { get; set; }

        public StatusData noresult { get; set; }

        public StatusData updatebar { get; set; }

        public StatusData handpick { get; set; }

        public P4P p4p { get; set; }

        public ShopList shoplist { get; set; }
    }

    public class ShopList
    {
        public ShopData data { get; set; }

        public bool export { get; set; }

        public string status { get; set; }
    }

    public class ShopData
    {
        public string apiUrl { get; set; }
        public string q { get; set; }

        public List<ShopItem> shopItems { get; set; }
    }

    public class ShopItem
    {
        public string uid { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 旺旺昵称
        /// </summary>
        public string nick { get; set; }
        public string provcity { get; set; }
        /// <summary>
        /// 销量
        /// </summary>
        public int totalsold { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary>
        public int procnt { get; set; }

        public string encodeNick { get; set; }
        public string dynamic { get; set; }
        /// <summary>
        /// 店铺地址
        /// </summary>
        public string shopUrl { get; set; }
        public string similarUrl { get; set; }
        public string picUrl { get; set; }
        public string rawTitle { get; set; }

        public bool hasMoreAuctions { get; set; }

        //public string mainAuction { get; set; }
        public string userRateUrl { get; set; }

        public bool isManjian { get; set; }
        public bool isSongli { get; set; }
        public bool isTmall { get; set; }
        public bool hasSimilar { get; set; }
        public bool isMianyou { get; set; }
        public bool isHideSale { get; set; }

        public string nid { get; set; }
        public string startFee { get; set; }
        public string discountCash { get; set; }
        public string giftName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ShopIcon shopIcon { get; set; }
    }

    public class ShopIcon
    {
        /// <summary>
        /// 等级
        /// </summary>
        public string iconClass { get; set; }
        public string trace { get; set; }
    }
    #endregion

    public class SendResultEventArgs : EventArgs
    {
        public int current { get; set; }
        public int totalCount { get; set; }
        public bool isok = false;

        public override string ToString()
        {
            if (current == totalCount)
            {
                isok = true;
                return "查询完成";
            }
            return string.Format("正在查询...{0}/{1}", current, totalCount);
        }
    }
}
