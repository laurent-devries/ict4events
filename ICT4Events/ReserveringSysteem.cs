﻿using Oracle.ManagedDataAccess.Client;
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
            cbEvents.DataSource = eventList;
        }

        private void cbEvents_SelectedValueChanged(object sender, EventArgs e)
        {
            Event el = cbEvents.SelectedItem as Event;
            CampingPlaceManager cpManager = new CampingPlaceManager();
            List<CampingPlace> campingPlaceList = cpManager.RequestFreeCampingPlaces(dtpAankomst.Value, dtpVertrek.Value, el);
            cbPlaces.Items.Clear();

            foreach (CampingPlace place in campingPlaceList)
            {
                cbPlaces.Items.Add(place);
            }

        }

        private void btn_Confirm_user_Click(object sender, EventArgs e)
        {
            Event a;
            {
                gb_gebruikercreatie.Enabled = false;
                gb_gebruikercreatie.Text = null;
                DatabaseConnection conn = new DatabaseConnection();
                string maand;
                string dag;
                if (dtp_geboortedatum_gebruiker.Value.Month < 10)
                {
                    maand = "0" + Convert.ToString(dtp_geboortedatum_gebruiker.Value.Month);
                }
                else
                {
                    maand = Convert.ToString(dtp_geboortedatum_gebruiker.Value.Month);
                }

                if (dtp_geboortedatum_gebruiker.Value.Day < 10)
                {
                    dag = "0" + Convert.ToString(dtp_geboortedatum_gebruiker.Value.Day);
                }
                else
                {
                    dag = Convert.ToString(dtp_geboortedatum_gebruiker.Value.Day);
                }

                MessageBox.Show(maand);
                a = cbEvents.SelectedItem as Event; 
                conn.InsertOrUpdate("INSERT INTO ICT4_RESERVATION (id_reservation,id_eventFK,id_campingPlaceFK,startDate,endDate,paymentState) VALUES(RESERVATION_SEQ.NEXTVAL," + Convert.ToString(a.ID_Event) + ", CAMPINGPLACE, to_date(" + Convert.ToString(dtpAankomst.Value) + ", 'dd-mm-yyyy'), to_date(Convert.ToString(dtpVertrek.Value), 'dd-mm-yyyy'), 'N'");
                conn.InsertOrUpdate("INSERT INTO ICT4_USER (id_user,id_eventFK,id_reservationFK,id_permissionFK,firstName,surName,birthDate,email,country,street,houseNumber,city,cellphoneNumber,loginName,userName,passwordUser,profilePic,summaryUser,presentUser) VALUES(USER_SEQ.NEXTVAL, 111," + Convert.ToInt32(cB_Reservation_ID_User.Text) + "," + 1 + ",'" + tb_voornaam_gebruiker.Text + "','" + tb_achternaam_user.Text + "', to_date('" + dag + maand + Convert.ToString(dtp_geboortedatum_gebruiker.Value.Year) + "','DD-MM-YYYY') ,'" + tb_email_gebruiker.Text + "','" + cb_land_gebruiker.Text + "','" + tb_straat_user.Text + "','" + tb_number_user.Text + "','" + tb_stad_user.Text + "','" + tb_telnr_gebruiker.Text + "','" + tb_loginname_gebruiker.Text + "','" + tb_username_gebruiker.Text + "','" + tb_password_gebruiker.Text + "','C:/','No Summary','N')");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Event el = cbEvents.SelectedItem as Event;
            CampingPlaceManager cpManager = new CampingPlaceManager();
            List<CampingPlace> campingPlaceList = cpManager.RequestFreeCampingPlaces(dtpAankomst.Value, dtpVertrek.Value, el);
            cbPlaces.Items.Clear();

            foreach (CampingPlace place in campingPlaceList)
            {
                cbPlaces.Items.Add(place);
            }

        }
    }
}
