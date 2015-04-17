using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

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

        private List<Media> mediaList;

        //Properties
        public string Title { get; set; }
        public string Date { get; set; }
        public string Summary { get; set; }
        public int Views { get { return views; } set { views = value; } }
        public string File_path { get; set; }
        public string Type_Media { get; set; }
        public int ID_Media { get { return id_media; } }
        public int Likes { get { return likes; } set { likes = value; } }

        //Methods
        public Media(string title, string date, string summary, int views, int likes, string file_Path, string type_Media)
        {
            this.id_media = idnumber;
            idnumber++;
            Title = title;
            Date = date;
            Summary = summary;
            Views = views;
            File_path = file_Path;
            Type_Media = type_Media;
            Likes = likes;
        }

        public Media()
        {
            mediaList = new List<Media>();
        }

        public List<Media> RequestMedia()
        {
            DatabaseConnection con = new DatabaseConnection();
            string Querry = "SELECT TITLE, to_char(DATEMEDIA), SUMMARYMEDIA,  to_char(viewMedia), to_char(likes), FILEPATH  FROM ICT4_MEDIA";

            OracleDataReader reader = con.SelectFromDatabase(Querry);
            Media media;
            while (reader.Read())
            {
                media = new Media(reader.GetString(0), reader.GetString(1), reader.GetString(2), Convert.ToInt32(reader.GetString(3)), Convert.ToInt32(reader.GetString(4)), reader.GetString(5), "VIDEO");
                mediaList.Add(media);
            }

            reader.Dispose();

            return mediaList;
        }

        public void InsertMedia(string title, string summaryMedia, string filePath, string typeMedia, DateTime currentDate)
        {
            DatabaseConnection con = new DatabaseConnection();

            string dateMonth = Convert.ToString(currentDate.Month);
            if (currentDate.Month < 10)
            {
                dateMonth = "0" + dateMonth;
            }

            string Query = "INSERT INTO ICT4_MEDIA(ID_MEDIA,TITLE,DATEMEDIA,SUMMARYMEDIA,VIEWMEDIA,FILEPATH,TYPEMEDIA) VALUES(232323,'" + title + "', to_date('" + Convert.ToString(currentDate.Day) + dateMonth + Convert.ToString(currentDate.Year) + "', 'DDMMYYYY'),'" + summaryMedia + "', 50000,'" + filePath + "','" + typeMedia + "')";
            bool writer = con.InsertOrUpdate(Query);
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
