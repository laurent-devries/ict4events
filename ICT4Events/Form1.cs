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
    public partial class FormBasicGUI : Form
    {
        public FormBasicGUI()
        {
            InitializeComponent();

            NewsfeedItem item = new NewsfeedItem("Titel", "datum", "Views", "Likes", "Message", 50, 50, pnlNewsFeed);
            TextBox titel = new TextBox();
            Panel p = new Panel();
            p.Location = new Point(50, 50);
            p.BackColor = Color.Red;
            p.Visible = true;
            pnlNewsFeed.Controls.Add(p);
            
        }

        /*public void loadItems
        {

        }
         */

    }
}
