using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events
{
    //Laurent de Vries
    public class Media
    {
        //Fields
        private static int idnumber = 0;
        private int id_media;
        private int likes;
        private int reports;
        private int views;

        //Properties
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Summary { get; set; }
        public int Views { get { return views; } set { views = value; } }
        public string File_path { get; set; }
        public string Type_Media { get; set; }
        public int ID_Media { get { return id_media; } }

        //Methods
        public Media(string title, DateTime date, string summary, int views, string file_Path, string type_Media)
        {
            this.id_media = idnumber;
            idnumber++;
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
