﻿using System;
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
        private DateTime startdate;
        private DateTime enddate;
        private string campingname;
        private string location;
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
        public DateTime StartDate
        {
            get { return startdate; }
            set { startdate = value; }
        }
        public DateTime EndDate
        {
            get { return enddate; }
            set { enddate = value; }
        }
        public string Campingname
        {
            get { return campingname; }
            set { campingname = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public Event(int ID_event, string Title, DateTime StartDate, DateTime EndDate, string Campingname, string Location)
        {
            this.id_event = ID_event;
            this.title = Title;
            this.startdate = StartDate;
            this.enddate = EndDate;
            this.campingname = Campingname;
            this.location = Location;
        }

    }
}
