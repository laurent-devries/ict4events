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
        int count = 0;
        List<NewsFeedItem> itemlist = new List<NewsFeedItem>();
        public FormBasicGUI()
        {
            InitializeComponent();

            lblIngelogdNaam.Location = new Point(this.Width - lblIngelogdNaam.Width - 30, 18);
            pbProfilePicture.Location = new Point(this.Width - lblIngelogdNaam.Width - 85, 2);

            panel1.Location = new Point(0, 0);
            panel1.Width = Width;

            pnlNewsFeed.Location = new Point(Width / 6, Height / 10);
            pnlNewsFeed.Width = Width / 6 * 4;
            pnlNewsFeed.Height = Height / 10 * 8;

            Panel p = new Panel();
            NewsFeedItem item1 = new NewsFeedItem("Titel", "datum", "Views", "Likes", "Message", p, pnlNewsFeed, count);
            count += 1;
            Panel p2 = new Panel();
            NewsFeedItem item2 = new NewsFeedItem("Titel", "datum", "Views", "Likes", "Message", p2, pnlNewsFeed, count);
            count += 1;
            Panel p3 = new Panel();
            NewsFeedItem item3 = new NewsFeedItem("Titel", "datum", "Views", "Likes", "Message", p3, pnlNewsFeed, count);

            itemlist.Add(item1);
            itemlist.Add(item2);
            itemlist.Add(item3);
            

            foreach (NewsFeedItem item in itemlist)
            {
                pnlNewsFeed.Controls.Add(item.Panel);                
            }
            
        }

        private void FormBasicGUI_Resize(object sender, EventArgs e)
        {
            pnlNewsFeed.Refresh();
            panel1.Width = this.Width;
            pnlNewsFeed.Width = this.Width / 6 * 4;
            pnlNewsFeed.Height = this.Height / 10 * 8;

            lblIngelogdNaam.Location = new Point(this.Width - lblIngelogdNaam.Width - 30, 18);
            pbProfilePicture.Location = new Point(this.Width - lblIngelogdNaam.Width - 85, 2);

            foreach(NewsFeedItem item in itemlist)
            {
                item.Panel.Location = new Point(pnlNewsFeed.Width / 3 * item.Count + 10, 10);
            }
        }

        /*public void loadItems
        {

        }
         */

    }
}
