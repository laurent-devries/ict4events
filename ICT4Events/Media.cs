using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events
{
    //Laurent de Vries
    class Media
    {
        //Fields
        int ID_Media;
        int likes;
        int reports;
        int views;
        List<Tag> tags = new List<Tag>();
        List<Comment> comments = new List<Comment>();

        //Properties
        string Title { get; set; }
        DateTime Date { get; set; }
        string Summary { get; set; }
        int Views { get { return views; } set { views = value; } }
        string File_path { get; set; }
        string Type_Media { get; set; }

        //Methods
        public Media(int id_Media, string title, DateTime date, string summary, int views, string file_Path, string type_Media)
        {
            this.ID_Media = id_Media;
            Title = title;
            Date = date;
            Summary = summary;
            Views = views;
            File_path = file_Path;
            Type_Media = type_Media;
        }

        public bool CheckAbuse(string abusiveWord)
        {
            return true; 
        }

        public int GetLikes()
        {
            return likes;
        }

        public int getReports()
        {
            return reports;
        }

        public int getViews()
        {
            return views;
        }
    }
}
