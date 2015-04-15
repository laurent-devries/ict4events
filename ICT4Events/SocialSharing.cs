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
    public partial class SocialSharing : Form
    {
        int countWidth = 0;
        int countHeight = 0;

        int loadStarter = 0;
        int loadEnder = 6;

        bool startup = false;

        List<NewsFeedItem> itemlist = new List<NewsFeedItem>();
        List<Media> mediaList;


        public SocialSharing()
        {
            InitializeComponent();

            //ScrollBar scrollbar = new VScrollBar();
            //scrollbar.Dock = DockStyle.Right;
            //scrollbar.Scroll += (sender, e) => {pnlNewsFeed.VerticalScroll.Value = scrollbar.Value;};
            //scrollbar.Maximum = 20;
            //pnlNewsFeed.Controls.Add(scrollbar);
            Media mediaData = new Media();
            mediaList = mediaData.RequestMedia();


            lblIngelogdNaam.Location = new Point(this.Width - lblIngelogdNaam.Width - 30, 18);
            pbProfilePicture.Location = new Point(this.Width - lblIngelogdNaam.Width - 85, 2);

            panel1.Location = new Point(0, 0);
            panel1.Width = Width;

            pnlNewsFeed.Location = new Point(Width / 6, Height / 10);
            pnlNewsFeed.Width = Width / 6 * 4;
            pnlNewsFeed.Height = Height / 10 * 8;

            
            if (startup == false)
            {
                loadMedia(0, 6);

            }
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadStarter = loadStarter + 6;
            loadEnder = loadStarter + 6;
            loadMedia(loadStarter, loadEnder);

            btnPreviousPage.Enabled = true;
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            loadStarter = loadStarter -= 6;
            loadEnder -= 6;
            loadMedia(loadStarter, loadEnder);

            btnNextPage.Enabled = true;            
        }

        
             

        public void loadMedia(int start, int end)
        {
            LoadMediaFiles(start, end);

            foreach (NewsFeedItem item in itemlist)
            {
                pnlNewsFeed.Controls.Add(item.Panel);
                Panel p = item.Panel;
                p.ForeColor = Color.CadetBlue;
                p.BringToFront();
            }
        }

        /* private void SocialSharing_Resize(object sender, EventArgs e)
        {
            pnlNewsFeed.Refresh();
            panel1.Width = this.Width;
            pnlNewsFeed.Width = this.Width / 6 * 4;
            pnlNewsFeed.Height = this.Height / 10 * 8;

            lblIngelogdNaam.Location = new Point(this.Width - lblIngelogdNaam.Width - 30, 18);
            pbProfilePicture.Location = new Point(this.Width - lblIngelogdNaam.Width - 85, 2);

            foreach (NewsFeedItem item in itemlist)
            {
                item.Panel.Location = new Point(pnlNewsFeed.Width / 3 * item.Count + 10, pnlNewsFeed.Width / 3 * item.Count + 10);
            }
        }
        */


        public void LoadMediaFiles(int start, int end)
        {
            if (mediaList.Count < end)
            {
                end = mediaList.Count;
                btnNextPage.Enabled = false;
            }

            if (end <= 6)
            {
                btnPreviousPage.Enabled = false;
            }

            pnlNewsFeed.Controls.Clear();
            itemlist.Clear();
            countWidth = 0;
            countHeight = 0;

            for (int i = start; i < end; i++)
            {
                Media media = mediaList[i];
                Panel p = new Panel();
                NewsFeedItem item = new NewsFeedItem(media.Title, media.Date, media.Views.ToString(), "Likes", media.Summary, p, pnlNewsFeed, i, countWidth, countHeight);

                countWidth++;


                if (countWidth > 2)
                {
                    countHeight++;
                    countWidth = 0;
                }

                itemlist.Add(item);
            }
        }

       }
   }

