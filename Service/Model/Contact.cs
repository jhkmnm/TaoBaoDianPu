using System;
using Dos.ORM;

namespace Service.Model
{
    /// <summary>
    /// 实体类Contact。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("Contact")]
    [Serializable]
    public partial class Contact : Entity
    {
        #region Model
        private string _ShopID;
        private string _ContactName;
        private string _ContactTime;

        /// <summary>
        /// 
        /// </summary>
        [Field("ShopID")]
        public string ShopID
        {
            get { return _ShopID; }
            set
            {
                this.OnPropertyValueChange("ShopID");
                this._ShopID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("ContactName")]
        public string ContactName
        {
            get { return _ContactName; }
            set
            {
                this.OnPropertyValueChange("ContactName");
                this._ContactName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("ContactTime")]
        public string ContactTime
        {
            get { return _ContactTime; }
            set
            {
                this.OnPropertyValueChange("ContactTime");
                this._ContactTime = value;
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
                _.ShopID,
            };
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.ShopID,
                _.ContactName,
                _.ContactTime,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._ShopID,
                this._ContactName,
                this._ContactTime,
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
            public readonly static Field All = new Field("*", "Contact");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ShopID = new Field("ShopID", "Contact", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ContactName = new Field("ContactName", "Contact", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ContactTime = new Field("ContactTime", "Contact", "");
        }
        #endregion
    }
}