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
        MediaManager m;
        Label lblOpenComment;
        int i = 0;
        int id;
        List<Media> medialist;
        List<Comment> commentList;
        public CommentNewsfeedItem(string titel, int id)
        {
            InitializeComponent();
            this.id = id;
            m = new MediaManager();
            medialist = m.RequestMedia();
            commentList = m.RequestComments(id);
            

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

            foreach (Comment c in commentList)
            {
                lblOpenComment = new Label();
                
                lblOpenComment.Location = new Point(0, lbCommentLoader.Height / 6 * i);
                i++;
                lbCommentLoader.Items.Add(c.ToString());
            }          
            
        }

        private void btnUploadComment_Click(object sender, EventArgs e)
        {
            m.InsertComment(rtbComment.Text, id);
        }

        private void CommentNewsfeedItem_Load(object sender, EventArgs e)
        {
            
        }
    }
}
