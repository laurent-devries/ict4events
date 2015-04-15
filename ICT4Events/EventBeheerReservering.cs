using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
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
        List<Event> evenementen;
        List<User> userList;
        public EventBeheerReservering()
        {
            InitializeComponent();
            evenementen = new List<Event>();
            DatabaseConnection conn = new DatabaseConnection();
            string Querry = "SELECT ID_EVENT, TITLE, DATEICT, STARTDATE, ENDDATE, CAMPINGNAME, LOCATION FROM ICT4_EVENT";
            OracleDataReader reader = conn.SelectFromDatabase(Querry);
            while (reader.Read())
            {
                Event event1 = new Event(reader.GetString(1), reader.GetDateTime(2), reader.GetDateTime(4), reader.GetString(5), reader.GetString(6));
                evenementen.Add(event1);
            }
            User Users = new User();
            userList = Users.RequestUsers();
            lists();
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
        private void lists()
        {
            
            if (userList != null)
            {
                Listb_gebruikers.Items.Clear();
                foreach (User user in userList)
                {
                    MessageBox.Show(user.First_Name + user.RFID_Tag);
                    Listb_gebruikers.Items.Add(user.ID_User + "," + user.First_Name + ", " + user.Sur_Name + ", " + user.RFID_Tag);
                }
            }
            if (evenementen != null)
            {
                Listb_Events.Items.Clear();
                foreach (Event event1 in evenementen)
                {
                    Listb_Events.Items.Add(event1.ID_Event + "," + event1.Campingname + ", " + event1.Location);
                }
            }

        }
    }
}
