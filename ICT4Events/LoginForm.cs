using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT4Events
{
    public partial class LoginForm : Form
    {
        User user;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User dataUser = new User();
            string userName = tbUsername.Text;
            string password = tbPassword.Text;
            user = dataUser.LoginUser(userName, password);

            MessageBox.Show(user.Username);
        }
    }
}
