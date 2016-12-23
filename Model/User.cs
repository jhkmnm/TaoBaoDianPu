using System;
using Dos.ORM;

namespace Model
{
    /// <summary>
    /// 实体类User。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("User")]
    [Serializable]
    public partial class User : Entity
    {
        #region Model
        private int _ID;
        private string _UserName;
        private string _Password;
        private string _IsAdmin;

        /// <summary>
        /// 
        /// </summary>
        [Field("ID")]
        public int ID
        {
            get { return _ID; }
            set
            {
                this.OnPropertyValueChange("ID");
                this._ID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("UserName")]
        public string UserName
        {
            get { return _UserName; }
            set
            {
                this.OnPropertyValueChange("UserName");
                this._UserName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Password")]
        public string Password
        {
            get { return _Password; }
            set
            {
                this.OnPropertyValueChange("Password");
                this._Password = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("IsAdmin")]
        public string IsAdmin
        {
            get { return _IsAdmin; }
            set
            {
                this.OnPropertyValueChange("IsAdmin");
                this._IsAdmin = value;
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
                _.ID,
            };
        }
        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        public override Field GetIdentityField()
        {
            return _.ID;
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.ID,
                _.UserName,
                _.Password,
                _.IsAdmin,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._ID,
                this._UserName,
                this._Password,
                this._IsAdmin,
            };
        }
        /// <summary>
        /// 是否是v1.10.5.6及以上版本实体。
        /// </summary>
        /// <returns></returns>
        public override bool V1_10_5_6_Plus()
        {
            return true;
        }
        #endregion

        #region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// * 
            /// </summary>
            public readonly static Field All = new Field("*", "User");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "User", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UserName = new Field("UserName", "User", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Password = new Field("Password", "User", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IsAdmin = new Field("IsAdmin", "User", "");
        }
        #endregion
    }
}