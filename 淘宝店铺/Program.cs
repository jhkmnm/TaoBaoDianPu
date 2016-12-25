using System;
using System.Windows.Forms;

namespace 淘宝店铺
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormLogin());

            FormLogin f = new FormLogin();
            if (f.ShowDialog() == DialogResult.OK)
            {
                FormMain fm = new FormMain();
                fm.ShowDialog();
            }
        }
    }

    public class UserInfo
    {
        private static string _username;
        private static bool _isadmin;

        public static void SetUserInfo(string userName, bool isAdmin)
        {
            _username = userName;
            _isadmin = isAdmin;
        }

        public static string UserName { get { return _username; } }
        public static bool IsAdmin { get { return _isadmin; } }
    }

    public class Tool
    {
        public static localhost.Service service = new localhost.Service();
    }
}
