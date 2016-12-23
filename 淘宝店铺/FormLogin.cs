using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace 淘宝店铺
{
    public partial class FormLogin : Form
    {
        localhost.WebService service = new localhost.WebService();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool login = true;
            label3.Visible = lblUserName.Visible = lblPassword.Visible = false;

            if(string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                lblUserName.Visible = true;
                login = false;
            }

            if(string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblPassword.Visible = true;
                login = false;
            }

            if (login)
            {
                JsMd5 m = new JsMd5();

                var result = service.UserLogin(txtUserName.Text, m.md5(txtPassword.Text).ToString());
                if (string.IsNullOrWhiteSpace(result))
                {
                    label3.Visible = true;
                }
                else
                {
                    var user = JsonConvert.DeserializeObject<Model.User>(result);
                    UserInfo.SetUserInfo(user.UserName, user.IsAdmin == "是");

                    new FormMain().Show();
                    this.Close();
                }
            }
        }
    }
}
