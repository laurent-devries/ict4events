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
        private string like;
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
        public Note(string Like)
        {
            this.like = Like;
            
        }
    }
}
