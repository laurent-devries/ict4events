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
        List<Reservation> reservations;
        public EventBeheerReservering()
        {
            InitializeComponent();
            EventManager Event = new EventManager();
            evenementen = Event.RequestEvent();
            UserManager Users = new UserManager();
            userList = Users.RequestUsers();
            Reservation Reservation = new Reservation();
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
            gb_gebruikercreatie.Text = null;
            DatabaseConnection conn = new DatabaseConnection();
            string maand;
            if (dtp_geboortedatum_gebruiker.Value.Month < 10)
            {
                maand = "0" + Convert.ToString(dtp_geboortedatum_gebruiker.Value.Month);
            }
            else
            {
                maand = Convert.ToString(dtp_geboortedatum_gebruiker.Value.Month);
            }
            MessageBox.Show(maand);
            conn.InsertOrUpdate("INSERT INTO ICT4_USER (id_user,id_eventFK,id_reservationFK,id_permissionFK,firstName,surName,birthDate,email,country,street,houseNumber,city,cellphoneNumber,loginName,userName,passwordUser,profilePic,summaryUser,presentUser) VALUES(USER_SEQ.NEXTVAL," + Convert.ToInt32(cB_Event_ID_User.Text) + "," + Convert.ToInt32(cB_Reservation_ID_User.Text) + "," + 1 + ",'" + tb_voornaam_gebruiker.Text + "','" + tb_achternaam_user.Text + "', to_date('" + Convert.ToString(dtp_geboortedatum_gebruiker.Value.Day) + maand + Convert.ToString(dtp_geboortedatum_gebruiker.Value.Year) + "','DDMMYYYY') ,'" + tb_email_gebruiker.Text + "','" + cb_land_gebruiker.Text + "','" + tb_straat_user.Text + "','" + tb_number_user.Text + "','" + tb_stad_user.Text + "','" + tb_telnr_gebruiker.Text + "','" + tb_loginname_gebruiker.Text + "','" + tb_username_gebruiker.Text + "','" + tb_password_gebruiker.Text + "','C:/','No Summary','N')");
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
                    Listb_gebruikers.Items.Add(user.ToString());
                    
                }
            }
            if (evenementen != null)
            {
                Listb_Events.Items.Clear();
                foreach (Event event1 in evenementen)
                {
                    Listb_Events.Items.Add(event1.ToString());
                    cB_Event_ID_User.Items.Add(event1.ID_Event);
                }
            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(dtp_geboortedatum_gebruiker.Value.Day) + Convert.ToString(dtp_geboortedatum_gebruiker.Value.Month) + Convert.ToString(dtp_geboortedatum_gebruiker.Value.Year));

        }

        //private void btn_create_event_Click(object sender, EventArgs e)
        //{
        //    DatabaseConnection conn = new DatabaseConnection();
        //    conn.InsertOrUpdate("INSERT INTO (ID_EVENT, TITLE, STARTDATE,ENDDATE,CAMPINGNAME,LOCATION) VALUES ("tb")");
        //}
    }
}
