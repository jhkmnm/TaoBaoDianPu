using System;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace 淘宝店铺
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            Tool.service.Url = System.Configuration.ConfigurationManager.AppSettings["dataSrvUrl"];
            StartPosition = FormStartPosition.CenterScreen;

#if DEBUG
            txtUserName.Text = "System";
            txtPassword.Text = "123456";
#endif
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            bool login = true;
            label3.Visible = lblUserName.Visible = lblPassword.Visible = false;

            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                lblUserName.Visible = true;
                login = false;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblPassword.Visible = true;
                login = false;
            }

            if (login)
            {
                JsMd5 m = new JsMd5();

                var result = Tool.service.UserLogin(txtUserName.Text, m.md5(txtPassword.Text).ToString());
                if (string.IsNullOrEmpty(result))
                {
                    label3.Visible = true;
                }
                else
                {
                    Model.User user = JsonConvert.DeserializeObject<Model.User>(result);
                    UserInfo.SetUserInfo(user.UserName, user.IsAdmin == "是");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                Login();
            }
        }
    }
}
