using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events
{
    //Laurent de Vries
    public class Note
    {
        private static int idnumber = 0;
        private int id_note;
        private string like = null;
        private string report = null;
        public string Like
        {
            get { return like; }
            set { like = value; }
        }
        public string Report
        {
            get { return report; }
            set { report = value; }
        }
        public int ID_Note
        {
            get { return id_note; }
        }
        public Note(string Like)
        {
            this.like = Like;
            this.id_note = idnumber;
            idnumber++;
        }
        public Note(string Report)
        {
            this.report = Report;
            this.id_note = idnumber;
            idnumber++;
        }
    }
}
