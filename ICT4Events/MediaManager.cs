using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Types;
using Oracle.ManagedDataAccess.Client;

namespace ICT4Events
{
    class MediaManager
    {
        List<Media> mediaList = new List<Media>();
        public List<Media> RequestMedia()
        {
            DatabaseConnection con = new DatabaseConnection();
            string Querry = "SELECT TITLE, to_char(DATEMEDIA), SUMMARYMEDIA,  to_char(viewMedia), to_char(likes), to_char(reports), FILEPATH  FROM ICT4_MEDIA";

            OracleDataReader reader = con.SelectFromDatabase(Querry);
            Media media;
            while (reader.Read())
            {
                int aantalLikes;
                int aantalReports;
                try
                {
                    aantalLikes = Convert.ToInt32(reader.GetString(4));
                    aantalReports = Convert.ToInt32(reader.GetString(5));
                }
                catch
                {
                    aantalLikes = 0;
                    aantalReports = 0;
                }
                media = new Media(reader.GetString(0), reader.GetString(1), reader.GetString(2), Convert.ToInt32(reader.GetString(3)), aantalLikes, aantalReports, reader.GetString(6), "VIDEO");
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

        public void UpdateLikes(string title)
        {
            DatabaseConnection con = new DatabaseConnection();

            string Query = "UPDATE ICT4_MEDIA SET likes = likes + 1 WHERE title = '" + title + "'";
            bool writer = con.InsertOrUpdate(Query);
        }

        public void UpdateReports(string title)
        {
            DatabaseConnection con = new DatabaseConnection();

            string Query = "UPDATE ICT4_MEDIA SET reports = reports + 1 WHERE title = '" + title + "'";
            bool writer = con.InsertOrUpdate(Query);
        }
    }
}
