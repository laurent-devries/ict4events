using System;
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
            RFIDtext.Text = (e.Tag);
            scanned = true;

        }

        private void rfid_Error(object sender, ErrorEventArgs e)
        {
            MessageBox.Show(e.Description);
        }

        private void BttngetInfo_Click(object sender, EventArgs e)
        {
            lblRFIDinfoUser.Text = RFIDtext.Text;
            DatabaseConnection conn = new DatabaseConnection();

            OracleDataReader reader = conn.SelectFromDatabase("SELECT SURNAME, ID_USER, FIRSTNAME, SURNAME, BIRTHDATE, EMAIL, COUNTRY, STREET, HOUSENUMBER, CITY, CELLPHONENUMBER, LOGINNAME, USERNAME FROM ICT4_USER where RFIDTAG =" + "'"+ RFIDtext.Text +"'");
            
            while(reader.Read())
            {
                try
                {
                    //lblSureNameHR.Text = reader.GetString(0);
                    //lblRFIDinfoUser.Text = reader.GetString(1);
                    //lblFirstHR.Text = reader.GetString(2);
                    //lblSureNameHR.Text = reader.GetString(3);
                    //lblBirthDHR.Text = Convert.ToString(reader.GetDateTime(4));
                    //lblEmailHR.Text = reader.GetString(5);
                    //lblCountryHR.Text = reader.GetString(6);
                    //lblStreetHR.Text = reader.GetString(7);
                    //lblHouseNBHR.Text = reader.GetString(8);
                    //lblCityHR.Text = reader.GetString(9);
                    //lblCellPhoneNBHR.Text = reader.GetString(10);
                    //lblLoginHR.Text = reader.GetString(11);
                    //lbluserHS.Text = reader.GetInt32(12);

                    

                }
                catch(Exception s)
                {
                    MessageBox.Show(s.ToString());
                }

            }
            

            reader.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
