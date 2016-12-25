using Newtonsoft.Json;
using System;
using System.Web.Services;

/// <summary>
/// Service 的摘要说明
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
// [System.Web.Script.Services.ScriptService]
public class Service : System.Web.Services.WebService
{
    DAL dal = new DAL();

    public Service()
    {

        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }
    [WebMethod]
    public string AddUser(string username, string password)
    {
        var v = dal.AddUser(new Model.User { UserName = username, Password = password });
        return JsonConvert.SerializeObject(v);
    }

    [WebMethod]
    public string UserLogin(string username, string password)
    {
        var user = dal.UserLogin(new Model.User { UserName = username, Password = password });
        return user == null ? "" : JsonConvert.SerializeObject(user);
    }

    [WebMethod]
    public string AddContact(string shopId, string userName)
    {
        var v = dal.AddContact(new Model.Contact { ContactName = userName, ContactTime = DateTime.Now.ToString(), ShopID = shopId });
        return JsonConvert.SerializeObject(v);
    }

    [WebMethod]
    public bool CheckContact(string shopId)
    {
        return dal.CheckContact(shopId);
    }

    [WebMethod]
    public string CheckContacts(string[] shopIds)
    {
        var v = dal.CheckContact(shopIds);
        return JsonConvert.SerializeObject(v);
    }

    [WebMethod]
    public string GetUserList()
    {
        var v = dal.GetUserList();
        return JsonConvert.SerializeObject(v);
    }
}
