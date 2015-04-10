using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events
{
    //Laurent de Vries
    class Comment
    {
        //Fields
        int id_Comment;
        string comment;
        DateTime Date { get; set; }
        
        //Constructor
        public Comment(int id_Comment, DateTime date, string comment)
        {
            this.id_Comment = id_Comment;
            this.comment = comment;
            Date = date;
        }

        public bool checkAbuse()
        {
            return true;
        }
    }
}
