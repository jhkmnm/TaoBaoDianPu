using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;

namespace Service
{
    /// <summary>
    /// WebService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        DAL.DAL dal = new DAL.DAL();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int AddUser(string username, string password)
        {
            return dal.AddUser(new Model.User { UserName = username, Password = password });
        }

        [WebMethod]
        public string UserLogin(string username, string password)
        {
            var user = dal.UserLogin(new Model.User { UserName = username, Password = password });
            return JsonConvert.SerializeObject(user);
        }

        [WebMethod]
        public string AddContact(string shopId, string userName)
        {
            var v = dal.AddContact(new Model.Contact { ContactName = userName, ContactTime = DateTime.Now.ToString(), ShopID = shopId });
            return JsonConvert.SerializeObject(v);
        }
    }
}
