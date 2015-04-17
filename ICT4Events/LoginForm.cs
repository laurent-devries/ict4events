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

            try
            {
                user = dataUser.LoginUser(userName, password);

                if (cbFormLoader.Text == "Social media")
                {
                    SocialSharing s = new SocialSharing();
                    this.Close();
                    s.Show();
                }

                else if (cbFormLoader.Text == "Event beheer")
                {
                    EventBeheerReservering ev = new EventBeheerReservering();
                    this.Close();
                    ev.Show();
                }

                else if (cbFormLoader.Text == "Materiaal verhuur")
                {
                    Hiresystem h = new Hiresystem();
                    this.Close();
                    h.Show();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Login error");
            }
            

            MessageBox.Show(user.Username);
        }
    }
}
