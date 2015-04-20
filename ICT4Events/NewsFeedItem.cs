using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.IO;

namespace ICT4Events
{
    class NewsFeedItem
    {
        //Fields
        Label Titel;
        Label Datum;
        Label Views;
        Label Likes;
        LinkLabel Report;
        LinkLabel Like;
        private int count;
        private int id;

        //Properties
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private Panel panel;

        public Panel Panel
        {
            get { return panel; }
            set { panel = value; }
        }

        public int ID { get; set; }
        

        //Constructor
        public NewsFeedItem(string titel, string datum, string views, string likes, string reports, string message, string imagePath, Panel panel, Panel nieuwsfeedPanel, int count, int countWidth, int countHeight, User user, int id)
        {
            this.count = count;
            this.panel = panel;
            this.id = id;


            panel.Location = new Point(nieuwsfeedPanel.Width / 3 * countWidth + 10, nieuwsfeedPanel.Height / 2 * countHeight + 10);
            panel.Height = nieuwsfeedPanel.Height / 2 - 20;
            panel.BackColor = Color.BlanchedAlmond;
            panel.Visible = true;
            
            int wSpace = 10;
            int hSpace = panel.Height / 10;
            
            //Create newsfeeddesig + delegates
            Titel = new Label();
            Titel.Location = new Point(wSpace, 5);
            Titel.Text = titel;
            Titel.ForeColor = Color.DarkOrange;
            Titel.Font = new Font("Georgia", 11);
            Titel.Width = panel.Width - wSpace;
            panel.Controls.Add(Titel);
            Titel.BringToFront();
            Titel.Click += delegate
            {
                CommentNewsfeedItem commentNFI = new CommentNewsfeedItem(titel, id, panel);
                commentNFI.Show();
            };

            Datum = new Label();
            Datum.Location = new Point(wSpace, 10 + hSpace);
            Datum.Text = datum;
            Datum.Height = 15;
            Datum.ForeColor = Color.DarkOrange;
            panel.Controls.Add(Datum);

            Views = new Label();
            Views.Location = new Point(wSpace, 10 + hSpace * 2);
            Views.Text = "Views: " + views;
            Views.ForeColor = Color.DarkOrange;
            Views.Width = panel.Width / 2 - wSpace;
            Views.Height = 15;
            panel.Controls.Add(Views);            

            Likes = new Label();
            Likes.Location = new Point(panel.Width / 2, 10 + hSpace * 2);
            Likes.Text = "Likes: " + likes;
            Likes.Height = 15;
            Likes.ForeColor = Color.DarkOrange;
            panel.Controls.Add(Likes);

            PictureBox p = new PictureBox();
            p.Location = new Point(wSpace, 10 + hSpace * 3);
            p.BackColor = Color.Black;
            p.Width = panel.Width - wSpace * 2;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            if (File.Exists(imagePath))
            {
              p.Load(imagePath);
            }
            

            panel.Controls.Add(p);

            RichTextBox Message = new RichTextBox();
            Message.Location = new Point(wSpace, 10 + hSpace * 6);
            Message.Width = panel.Width - wSpace * 2;
            Message.Height = 60;
            Message.BackColor = Color.BlanchedAlmond;
            Message.Text = message;
            Message.ForeColor = Color.DarkOrange;
            Message.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(Message);

            Report = new LinkLabel();
            Report.Location = new Point(panel.Width - 30, 10 + hSpace * 9);
            Report.Text = "Report";
            Report.Height = 15;
            Report.Font = new Font("Georgia", 6);
            Report.ForeColor = Color.DarkOrange;
            panel.Controls.Add(Report);
            Report.Click += delegate
            {
                MediaManager m = new MediaManager();
                m.UpdateReports(titel);
            };

            Like = new LinkLabel();
            Like.Location = new Point(wSpace, 10 + hSpace * 9);
            Like.Text = "Like";
            Like.Height = 15;
            Like.Width = 50;
            Like.Font = new Font("Georgia", 6);
            Like.ForeColor = Color.DarkOrange;
            panel.Controls.Add(Like);
            Like.Click += delegate
            {
                MediaManager m = new MediaManager();
                m.UpdateLikes(titel);                
            };

            LinkLabel lblDownload = new LinkLabel();
            lblDownload.Location = new Point(panel.Width / 2 - wSpace * 2, 10 + hSpace * 9);
            lblDownload.Text = "Download";
            lblDownload.Height = 15;
            lblDownload.Font = new Font("Georgia", 6);
            lblDownload.ForeColor = Color.DarkOrange;
            panel.Controls.Add(lblDownload);
            lblDownload.Click += delegate
            {
                FTPConnection ftp = new FTPConnection(@"ftp://172.16.0.15/" , "client", "1233");
                string s = Path.GetFileName(imagePath);
                string q = Path.Combine("ftp://172.16.0.15/", s);
                string i = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), s);
                ftp.download( q, i);
            };
            
        }
    }
}
