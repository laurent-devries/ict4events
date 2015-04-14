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
    class NewsFeedItem
    {
        //Fields
        Label Titel;
        Label Datum;
        Label Views;
        Label Likes;
        LinkLabel Report;
        private int count;

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
        
        

        //Constructor
        public NewsFeedItem(string titel, string datum, string views, string likes, string message, Panel panel, Panel nieuwsfeedPanel, int count)
        {
            this.count = count;
            this.panel = panel;

            panel.Location = new Point(nieuwsfeedPanel.Width/ 3 * count + 10, 10);
            panel.Height = 200;
            panel.BackColor = Color.BlanchedAlmond;
            panel.Visible = true;
            
            int wSpace = 10;
            int hSpace = panel.Width / 10;
            

            Titel = new Label();
            Titel.Location = new Point(wSpace, 5);
            Titel.Text = titel;
            Titel.ForeColor = Color.DarkOrange;
            Titel.Font = new Font("Georgia", 15);
            panel.Controls.Add(Titel);

            Datum = new Label();
            Datum.Location = new Point(wSpace, 10 + hSpace);
            Datum.Text = datum;
            Datum.ForeColor = Color.DarkOrange;
            panel.Controls.Add(Datum);

            Views = new Label();
            Views.Location = new Point(wSpace, 10 + hSpace * 2);
            Views.Text = views;
            Views.ForeColor = Color.DarkOrange;
            Views.Width = panel.Width / 4;
            Views.Height = 15;
            panel.Controls.Add(Views);            

            Likes = new Label();
            Likes.Location = new Point(panel.Width / 2, 10 + hSpace * 2);
            Likes.Text = likes;
            Likes.Height = 15;
            Likes.ForeColor = Color.DarkOrange;
            panel.Controls.Add(Likes);

            PictureBox p = new PictureBox();
            p.Location = new Point(wSpace, 10 + hSpace * 3);
            p.BackColor = Color.Black;
            p.Width = panel.Width - wSpace * 2;
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

        }
    }
}
