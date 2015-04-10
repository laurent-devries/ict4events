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
        private string likeOrReport;

        public Note(string likeOrReport)
        {
            this.likeOrReport = likeOrReport;
        }
    }
}
