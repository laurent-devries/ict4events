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
    public partial class ReserveringSysteem : Form
    {
        public ReserveringSysteem()
        {
            InitializeComponent();
            EventManager eventManager = new EventManager();
            List<Event> eventList = eventManager.RequestEvent();

            foreach (Event ev in eventList)
            {
                cbEvents.Items.Add(ev);
            }

            CampingPlaceManager cpManager = new CampingPlaceManager();
            List<CampingPlace> campingPlaceList = cpManager.RequestFreeCampingPlaces(dtpAankomst.Value, dtpVertrek.Value);
        }

        private void cbEvents_SelectedValueChanged(object sender, EventArgs e)
        {
            Event el = cbEvents.SelectedItem as Event;
            CampingPlaceManager cpManager = new CampingPlaceManager();
            List<CampingPlace> campingPlaceList = cpManager.RequestCampingPlaces(el);
            cbPlaces.Items.Clear();

            foreach (CampingPlace place in campingPlaceList)
            {
                cbPlaces.Items.Add(place);
            }

        }

        private void btn_Confirm_user_Click(object sender, EventArgs e)
        {
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
                Event ev = cbEvents.SelectedItem as Event;
                conn.InsertOrUpdate("INSERT INTO ICT4_USER (id_user,id_eventFK,id_reservationFK,id_permissionFK,firstName,surName,birthDate,email,country,street,houseNumber,city,cellphoneNumber,loginName,userName,passwordUser,profilePic,summaryUser,presentUser) VALUES(USER_SEQ.NEXTVAL," + Convert.ToInt32(ev.ID_Event) + "," + Convert.ToInt32(ev.ID_Event) + "," + 1 + ",'" + tb_voornaam_gebruiker.Text + "','" + tb_achternaam_user.Text + "', to_date('" + Convert.ToString(dtp_geboortedatum_gebruiker.Value.Day) + maand + Convert.ToString(dtp_geboortedatum_gebruiker.Value.Year) + "','DDMMYYYY') ,'" + tb_email_gebruiker.Text + "','" + cb_land_gebruiker.Text + "','" + tb_straat_user.Text + "','" + tb_number_user.Text + "','" + tb_stad_user.Text + "','" + tb_telnr_gebruiker.Text + "','" + tb_loginname_gebruiker.Text + "','" + tb_username_gebruiker.Text + "','" + tb_password_gebruiker.Text + "','C:/','No Summary','N')");
            }
        }
    }
}
