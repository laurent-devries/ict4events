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
    class NewsfeedItem
    {
        //Fields

        Label titel;
        Label datum = new Label();
        Label Views = new Label();
        Label Likes = new Label();
        Label Message = new Label();

        Point point = new Point();

        //Constructor
        public NewsfeedItem(string Titel, string datum, string views, string likes, string message, int startX, int startY, Panel panel)
        {
            titel = new Label();
            
            
            
        }
    }
}
