using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HireSystemICT4All
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblInfo.Visible = false;
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            PasswordTxt.PasswordChar = '*';
            PasswordTxt.MaxLength = 255;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = true;
            try
            {



                //string Connection = 
                //MySqlConnection myConn = new MySqlConnection(Connection);

                //MySqlCommand SelectCommand = new MySqlCommand(); //selects

                //MySqlDataReader myReader;
                // myConn.Open();
                // myReader = SelectCommand.ExecuteReader();
                int count = 0;
                // while (myReader.Read())
                    count = count + 1;

                if (count == 1)
                    lblInfo.Text = "Username and password is correct";
                else if (count > 1)
                    lblInfo.Text = "Duplicate username and password. Access is denied.";
                else
                    lblInfo.Text = "Username and password is incorrect. Please try again.";

                //myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

       
    }
}
