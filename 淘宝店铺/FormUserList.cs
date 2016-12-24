using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace 淘宝店铺
{
    public partial class FormUserList : Form
    {
        public FormUserList()
        {
            InitializeComponent();
            BindData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool login = true;
            lblUserName.Visible = lblPassword.Visible = false;

            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                lblUserName.Visible = true;
                login = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblPassword.Visible = true;
                login = false;
            }

            if(login)
            {
                JsMd5 m = new JsMd5();
                Tool.service.AddUser(txtUserName.Text, m.md5(txtPassword.Text).ToString());
                BindData();
            }
        }

        private void BindData()
        {
            var s = Tool.service.GetUserList();
            List<Model.User> datas = JsonConvert.DeserializeObject<List<Model.User>>(s);
            userBindingSource.DataSource = datas;
        }
    }
}
