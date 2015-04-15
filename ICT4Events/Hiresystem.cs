﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets; //voor het gebruik van RFID
using Phidgets.Events; //voor het gebruik van EVENTS (Attach etc.)
using Oracle.ManagedDataAccess.Client; 

namespace ICT4Events
{
    public partial class Hiresystem : Form
    {
        public Hiresystem()
        {
            InitializeComponent();
            lblWaiting.Text = "Waiting for RFID scan....";
            

        }


        private bool scanned = false;

        private void bttnEnableRFID_Click(object sender, EventArgs e)
        {
            try
            {
                if (scanned == false)
                {
                    RFID rfid = new RFID(); //RFID object
                    rfid.Attach += new AttachEventHandler(rfid_Attach);
                    rfid.Detach += new DetachEventHandler(rfid_Detach);
                    rfid.Error += new ErrorEventHandler(rfid_Error);
                    rfid.Tag += new TagEventHandler(rfid_Tag);

                    rfid.open();
                    rfid.Antenna = true;
                    rfid.LED = true;

                }
                else
                {
                    RFIDtext.Text = "";
                }
            }
            
            catch (PhidgetException ex)
            {
                MessageBox.Show(ex.Description);
            }
            
        }
                
        

        private void rfid_Attach(object sender, AttachEventArgs e)
        {
            lblconnectedInfo.Text = "connected";
            lblserialInfo.Text = e.Device.SerialNumber.ToString();

        }
        private void rfid_Detach(object sender, DetachEventArgs e)
        {
            lblconnectedInfo.Text = "disconnected";
            lblserialInfo.Text = "--";
        }

        public void rfid_Tag(object sender, TagEventArgs e)
        {

            lblWaiting.Text = "Scan succesfull";
            
            scanned = true;
            User user;
            User dataCollect = new User();
            user = dataCollect.SearchByRfid(e.Tag);
            if (user == null)
            {
                RFIDtext.Text = (e.Tag);
            }
            else 
            { 
                RFIDtext.Text = user.RFID_Tag;
                lblFirstHR.Text = user.First_Name;
                lblSureNameHR.Text = user.Sur_Name;
                lblRFIDinfoUser.Text = user.RFID_Tag; 
                lblBirthDHR.Text = Convert.ToString(user.Birth_Date);
                lblEmailHR.Text = user.Email;
                lblCountryHR.Text = user.Country;
               // lblStreetHR.Text = user.
               // lblHouseNBHR.Text = user.
                lblCityHR.Text = user.City;
                lblCellPhoneNBHR.Text = user.Phone_Number;
                lblLoginHR.Text = user.Login_Name;
                lbluserHS.Text = user.Username;
            }
        }

        private void rfid_Error(object sender, ErrorEventArgs e)
        {
            MessageBox.Show(e.Description);
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BttngetInfo_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
