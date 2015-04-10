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

            
            TextBox titel = new TextBox();
            Panel p = new Panel();
            p.Location = new Point(50, 50);
            p.Height = 200;
            p.BackColor = Color.Red;
            p.Visible = true;
            pnlNewsFeed.Controls.Add(p);
            NewsfeedItem item = new NewsfeedItem("Titel", "datum", "Views", "Likes", "Message", p);
            
        }

        /*public void loadItems
        {

        }
         */

    }
}
