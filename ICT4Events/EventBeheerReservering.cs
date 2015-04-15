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
    public partial class EventBeheerReservering : Form
    {

        public EventBeheerReservering()
        {
            InitializeComponent();
            User Users = new User();
            List<User> userList = Users.Requestuser();
            foreach (User user in userList)
            {
                Listb_gebruikers.Items.Add(user.ID_User +"," + user.Real_Name);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_nieuwe_gebruiker_Click(object sender, EventArgs e)
        {
            gb_gebruikercreatie.Enabled = true;
        }

        private void btn_create_gebruiker_Click(object sender, EventArgs e)
        {
            gb_gebruikercreatie.Enabled = false;
            Listb_gebruikers.Items.Add(tb_naam_gebruiker.Text);
            tb_naam_gebruiker.Clear();
        }

        private void Listb_gebruikers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
