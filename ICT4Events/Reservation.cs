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


        private int id_reservation;
        private int camping_place;
        private DateTime reservation_startdate;
        private DateTime reservation_enddate;
        Betalingstatus betalingstatus;
        public int ID_Reservation
        {
            get { return id_reservation; }
            set { id_reservation = value; }
        }
        public int Camping_place
        {
            get { return camping_place; }
            set { camping_place = value; }
        }
        public Betalingstatus Betalingstatus
        {
            get { return betalingstatus; }
            set { betalingstatus = value; }
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
        public Reservation(int ID_reservation, int Camping_place, Betalingstatus Betalingsstatus)
        {

        }
    }
}
