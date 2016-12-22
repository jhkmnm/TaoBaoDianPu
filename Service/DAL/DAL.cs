using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Service.Model;

namespace Service.DAL
{
    public class DAL
    {
        #region 用户
        public int AddUser(User data)
        {
            return DB.Context.Insert(data);
        }

        public User UserLogin(User data)
        {
            return DB.Context.From<User>()
                .Where(a => a.UserName == data.UserName && a.Password == data.Password)
                .ToFirst();
        }
        #endregion

        #region 联系记录
        public Result AddContact(Contact data)
        {
            var v = DB.Context.From<Contact>()
                .Where(a => a.ShopID == data.ShopID)
                .ToFirst();

            if(v == null)
            {
                var i = DB.Context.Insert(data);
                return new Result { Succeed = i > 0, Message = i > 0 ? "" : "添加联系记录失败" };
            }
            else
            {
                return new Result { Succeed = false, Message = "已经联系过" };
            }
        }
        #endregion
    }
}