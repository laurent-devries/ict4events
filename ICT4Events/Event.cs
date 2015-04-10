using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events
{
    /*
     * Gemaakt door Yoeri Vink
     * Laatste edit op 10-4-2015 10:01.
     */
    class Event
    {
        private int id_event;
        private string title;
        private DateTime date;

        public int ID_event
        {
            get { return id_event; }
            set { id_event = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public Event(int ID_event, string Title, DateTime Date)
        {
            this.id_event = ID_event;
            this.title = Title;
            this.date = Date;
        }

    }
}
