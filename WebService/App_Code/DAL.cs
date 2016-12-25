using Dos.ORM;
using Model;
using System.Collections.Generic;

/// <summary>
/// DAL 的摘要说明
/// </summary>
public class DAL
{
    #region 用户
    public Result AddUser(User data)
    {
        var user = DB.Context.From<User>()
            .Where(a => a.UserName == data.UserName)
            .First();
        if (user != null)
            return new Result { Succeed = false, Message = "存在相同的用户名!" };
        else
        {
            DB.Context.Insert(data);
            return new Result { Succeed = true, Message = "添加成功!" };
        }
    }

    public User UserLogin(User data)
    {
        return DB.Context.From<User>()
            .Where(a => a.UserName == data.UserName && a.Password == data.Password)
            .ToFirst();
    }

    public List<User> GetUserList()
    {
        return DB.Context.From<User>().ToList();
    }
    #endregion

    #region 联系记录
    public Result AddContact(Contact data)
    {
        var v = CheckContact(data.ShopID);

        if (!v)
        {
            var i = DB.Context.Insert(data);
            return new Result { Succeed = i > 0, Message = i > 0 ? "" : "添加联系记录失败" };
        }
        return new Result { Succeed = false, Message = "已经联系过" };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="shopId"></param>
    /// <returns>true:联系过 false:未联系</returns>
    public bool CheckContact(string shopId)
    {
        var v = DB.Context.From<Contact>()
            .Where(a => a.ShopID == shopId)
            .ToFirst();

        return v != null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="shipIds"></param>
    /// <returns>[1, 0] 1:联系过  0:未联系</returns>
    public Dictionary<string, string> CheckContact(string[] shipIds)
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();
        if (DB.Context.From<Contact>().Count() == 0)
            return dic;

        var v = DB.Context.From<Contact>()
            .Where(a => a.ShopID.In(shipIds))
            .ToList();

        v.ForEach(a => dic.Add(a.ShopID, a.ContactTime));
        return dic;
    }
    #endregion
}