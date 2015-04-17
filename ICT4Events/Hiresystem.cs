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
        List<Product> producten;
        //private List<Product> producten;
        public Hiresystem()
        {
            InitializeComponent();
            LoadProducts();
           loadasdasda();
            //CreateMyListView();


            // Product Product = new Product();
            //  Product = Product.RequestProducts();
            // lblWaiting.Text = "Waiting for RFID scan....";

        }

        private void Hiresystem_Load(object sender, EventArgs e)
        {




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
            UserManager dataCollect = new UserManager();
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


        private void BttngetInfo_Click_1(object sender, EventArgs e)
        {

        }


        public void LoadProducts()
        {
            Product productData = new Product();
            producten = productData.RequestProducts();
            foreach (Product product in producten)
            {
                listBox3.Items.Add(product);



            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void loadasdasda()
        {
            
			listView1.View = View.Details;
			listView1.LabelEdit = true;
			listView1.AllowColumnReorder = true;
			listView1.FullRowSelect = true;
			listView1.GridLines = true;
			listView1.Sorting = SortOrder.Ascending;
            
            Product productData = new Product();
            producten = productData.RequestProducts();
            listView1.Items.Clear();
            ListViewItem productname = new ListViewItem("productName", 1);
            ListViewItem productID = new ListViewItem("Product ID", 0);
            ListViewItem productBail = new ListViewItem("Bail", 2);
            ListViewItem productPrice = new ListViewItem("Price", 3);
           listView1.Columns.Add("Product ID", -2, HorizontalAlignment.Left);
           listView1.Columns.Add("Product Name", -2, HorizontalAlignment.Left);
           listView1.Columns.Add("Bail Price", -2, HorizontalAlignment.Left);
           listView1.Columns.Add("Product Price", -2, HorizontalAlignment.Left);
           listView1.Items.AddRange(new ListViewItem[] { productname, productID, productBail, productPrice });
               
            foreach (Product product in producten)
            {

                productname.SubItems.Add(product.Product_Name);
                productID.SubItems.Add(product.ID_Product.ToString());
                productBail.SubItems.Add(product.Bail.ToString());
                productPrice.SubItems.Add(product.Price.ToString());

                
            }
        }


            private void CreateMyListView()
		{
			// Create a new ListView control.
            
			

			// Set the view to show details.
			listView1.View = View.Details;
			// Allow the user to edit item text.
			listView1.LabelEdit = true;
			// Allow the user to rearrange columns.
			listView1.AllowColumnReorder = true;
			
			// Select the item and subitems when selection is made.
			listView1.FullRowSelect = true;
			// Display grid lines.
			listView1.GridLines = true;
			// Sort the items in the list in ascending order.
			listView1.Sorting = SortOrder.Ascending;
            			
			// Create three items and three sets of subitems for each item.
			ListViewItem item1 = new ListViewItem("item1",0);
			// Place a check mark next to the item.
			
			item1.SubItems.Add("1");
			item1.SubItems.Add("2");
			item1.SubItems.Add("3");
			ListViewItem item2 = new ListViewItem("item2",1);
			item2.SubItems.Add("4");
			item2.SubItems.Add("5");
			item2.SubItems.Add("6");
			ListViewItem item3 = new ListViewItem("item3",0);
			// Place a check mark next to the item.
			
			item3.SubItems.Add("7");
			item3.SubItems.Add("8");
			item3.SubItems.Add("9");

			// Create columns for the items and subitems. 
			
			listView1.Columns.Add("Item Column");
			listView1.Columns.Add("Column 2");
			listView1.Columns.Add("Column 3");
			listView1.Columns.Add("Column 4");

			//Add the items to the ListView.
            listView1.Items.AddRange(new ListViewItem[]{item1,item2,item3});

			// Add the ListView to the control collection. 
           // this.Controls.Add(listView1);
		
        }

            private void listView1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
    }
}
