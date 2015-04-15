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

        TextBox tTitleOfMedia;
        RichTextBox tMediaDescription;
        TextBox tMediaPath;


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

        private void button2_Click(object sender, EventArgs e)
        {
            pnlNewsFeed.Controls.Clear();
            btnNextPage.Visible = false;

            loadUploadingScreen();
        }

        public void loadUploadingScreen()
        {
            //Titel
            Label Titel = new Label();
            Titel.Location = new Point(pnlNewsFeed.Width / 2, 5);
            Titel.Text = "Upload";
            Titel.ForeColor = Color.DarkOrange;
            Titel.Font = new Font("Georgia", 20, FontStyle.Underline);
            Titel.Width = pnlNewsFeed.Width - 10;
            Titel.Height = 40;
            pnlNewsFeed.Controls.Add(Titel);

            

            //TitelOfMedia
            Label lTitleOfMedia = new Label();
            lTitleOfMedia.Location = new Point(10 , pnlNewsFeed.Height / 10 * 2);
            lTitleOfMedia.Text = "Title of Media";
            lTitleOfMedia.ForeColor = Color.DarkOrange;
            lTitleOfMedia.Font = new Font("Georgia", 13);
            lTitleOfMedia.Width = 140;
            lTitleOfMedia.Height = 20;
            pnlNewsFeed.Controls.Add(lTitleOfMedia);

            tTitleOfMedia = new TextBox();
            tTitleOfMedia.Location = new Point(lTitleOfMedia.Width + 10, pnlNewsFeed.Height / 10 * 2);
            tTitleOfMedia.Width = 150;
            pnlNewsFeed.Controls.Add(tTitleOfMedia);
            
            //MediaDescription
            Label lMediaDescription = new Label();
            lMediaDescription.Location = new Point(10, pnlNewsFeed.Height / 10 * 3);
            lMediaDescription.Text = "Description";
            lMediaDescription.ForeColor = Color.DarkOrange;
            lMediaDescription.Font = new Font("Georgia", 13);
            lMediaDescription.Width = 140;
            lMediaDescription.Height = 20;
            pnlNewsFeed.Controls.Add(lMediaDescription);

            tMediaDescription = new RichTextBox();
            tMediaDescription.Location = new Point(lTitleOfMedia.Width + 10, pnlNewsFeed.Height / 10 * 3);
            tMediaDescription.Width = 150;
            tMediaDescription.Height = tTitleOfMedia.Height * 3 ;
            pnlNewsFeed.Controls.Add(tMediaDescription);

            //MediaPath
            Label lMediaPath = new Label();
            lMediaPath.Location = new Point(10, pnlNewsFeed.Height / 10 * 5);
            lMediaPath.Text = "MediaPath";
            lMediaPath.ForeColor = Color.DarkOrange;
            lMediaPath.Font = new Font("Georgia", 13);
            lMediaPath.Width = 140;
            lMediaPath.Height = 20;
            pnlNewsFeed.Controls.Add(lMediaPath);

            Button bMediaPath = new Button();
            bMediaPath.Location = new Point(lTitleOfMedia.Width + 10, pnlNewsFeed.Height / 10 * 5 - 1);
            bMediaPath.Text = "Browse";
            pnlNewsFeed.Controls.Add(bMediaPath);

            Button bUpload = new Button();
            bUpload.Location = new Point(lTitleOfMedia.Width + 10, pnlNewsFeed.Height / 10 * 5 + bMediaPath.Height );
            bUpload.Text = "Upload";
            pnlNewsFeed.Controls.Add(bUpload);

            tMediaPath = new TextBox();
            tMediaPath.Location = new Point(lTitleOfMedia.Width + bMediaPath.Width + 10, pnlNewsFeed.Height / 10 * 5);
            tMediaPath.Width = 150 - bMediaPath.Width;
            pnlNewsFeed.Controls.Add(tMediaPath);

            //Preview
            Label lPreview = new Label();
            lPreview.Location = new Point(pnlNewsFeed.Width / 4 * 3 - 20, pnlNewsFeed.Height / 10 * 2);
            lPreview.Text = "Preview";
            lPreview.ForeColor = Color.DarkOrange;
            lPreview.Font = new Font("Georgia", 13);
            lPreview.Width = 140;
            lPreview.Height = 20;
            pnlNewsFeed.Controls.Add(lPreview);
        }

       }
   }

