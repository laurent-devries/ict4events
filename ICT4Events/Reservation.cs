using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events
{
    public enum Betalingstatus { Betaald, Niet_Betaald, Geweigerd, Geannuleerd };
    public class Reservation
    {
        private static int idnumber = 0;
        private Event event1;
        private int id_reservation;
        private string camping_place;
        private DateTime reservation_startdate;
        private DateTime reservation_enddate;
        Betalingstatus betalingstatus = Betalingstatus.Niet_Betaald;
        private List<User> reservationusers = new List<User>();
        public int ID_Reservation
        {
            get { return id_reservation; }
            
        }
        public string Camping_place
        {
            get { return camping_place; }
            set { camping_place = value; }
        }
        public DateTime Reservation_StartDate
        {
            get { return reservation_startdate; }
            set { reservation_startdate = value; }
        }
        public DateTime Reservation_EndDate
        {
            get { return reservation_enddate; }
            set { reservation_enddate = value; }
        }
        public Betalingstatus Betalingstatus
        {
            get { return betalingstatus; }
            set { betalingstatus = value; }
        }

        public Reservation(string Camping_place, DateTime Reservation_startdate, DateTime Reservation_enddate, Event Event)
        {
            this.id_reservation = idnumber;
            idnumber++;
            this.camping_place = Camping_place;
            this.event1 = Event;
            reservation_startdate = Reservation_startdate;
            reservation_enddate = Reservation_enddate;
        }
        public void Adduser(User user)
        {
            reservationusers.Add(user);
        }
        public void Removeuser(User user)
        {
            reservationusers.Remove(user);
        }
    }
}
