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
    public partial class CommentNewsfeedItem : Form
    {
        public CommentNewsfeedItem(string titel, int id, Panel panel)
        {
            InitializeComponent();

            MediaManager m = new MediaManager();
            List<Media> medialist = new List<Media>();
            List<Comment> commentList = new List<Comment>();
            medialist = m.RequestMedia();
            //commentList = m.RequestComments(id);
            

            foreach (Media media in medialist)
            {
                if (media.Title == titel)
                {
                    lblTitel.Text = media.Title;
                    lblDatum.Text = media.Date;
                    lblLikes.Text = "Likes : " + media.Likes.ToString();
                    lblViews.Text = "Views : " + media.Views.ToString();
                    rtbSummary.Text = media.Summary;
                    try
                    {
                        pbMedia.Load(media.File_path);
                    }
                    catch
                    {

                    }
                }
            }

            for (int i = 0; i<commentList.Count; i++)
            {
                RichTextBox rtbComment = new RichTextBox();
                int height = panel.Height / 8 * (4 + i);
                rtbComment.Height = height;
                rtbComment.Width = 10;
            }
            
            
        }

        private void btnUploadComment_Click(object sender, EventArgs e)
        {
           
        }

        private void CommentNewsfeedItem_Load(object sender, EventArgs e)
        {
            
        }
    }
}
