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
        private Button button1;
        //int count = 0;
        List<NewsFeedItem> itemlist = new List<NewsFeedItem>();
        public SocialSharing()
        {
            InitializeComponents();

            lblIngelogdNaam.Location = new Point(this.Width - lblIngelogdNaam.Width - 30, 18);
            pbProfilePicture.Location = new Point(this.Width - lblIngelogdNaam.Width - 85, 2);

            panel1.Location = new Point(0, 0);
            panel1.Width = Width;

            pnlNewsFeed.Location = new Point(Width / 6, Height / 10);
            pnlNewsFeed.Width = Width / 6 * 4;
            pnlNewsFeed.Height = Height / 10 * 8;



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

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SocShare
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Name = "SocShare";
            this.ResumeLayout(false);

        } 
        }
    }

