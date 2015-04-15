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
        //int count = 0;
        List<NewsFeedItem> itemlist = new List<NewsFeedItem>();
        public FormBasicGUI()
        {
            InitializeComponent();

            //Create baselocation for top information in gui
            lblIngelogdNaam.Location = new Point(this.Width - lblIngelogdNaam.Width - 30, 18);
            pbProfilePicture.Location = new Point(this.Width - lblIngelogdNaam.Width - 85, 2);

            panel1.Location = new Point(0, 0);
            panel1.Width = Width;

            pnlNewsFeed.Location = new Point(Width / 6, Height / 10);
            pnlNewsFeed.Width = Width / 6 * 4;
            pnlNewsFeed.Height = Height / 10 * 8;


            //Load media that is in database
            Media mediaData = new Media();
            List<Media> mediaList = mediaData.RequestMedia();
            for (int i = 0; i < mediaList.Count ; i++)
            {
                Media media = mediaList[i];
                Panel p = new Panel();
                NewsFeedItem item = new NewsFeedItem(media.Title, media.Date, media.Views.ToString(), "Likes", media.Summary, p, pnlNewsFeed, i);
                itemlist.Add(item);
            }           

            foreach (NewsFeedItem item in itemlist)
            {
                pnlNewsFeed.Controls.Add(item.Panel);                
            }
            
        }

        //Scale when form is Resized
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
