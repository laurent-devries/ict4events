using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events
{
    public class Reservation
    {

        private int id_reservation;
        private int id_eventFK;
        private string camping_place;
        private DateTime reservation_startdate;
        private DateTime reservation_enddate;
        private char paymentState;
        private List<User> reservationusers;
        private List<Reservation> reservations;
        public int ID_Reservation { get { return id_reservation; } }
        public int ID_EventFK { get { return id_eventFK; } }
        public string Camping_place { get { return camping_place; } set { camping_place = value; } }
        public DateTime Reservation_StartDate { get { return reservation_startdate; } set { reservation_startdate = value; } }
        public DateTime Reservation_EndDate { get { return reservation_enddate; } set { reservation_enddate = value; } }
        public char PaymentState { get { return paymentState; } set { paymentState = value; } }

        public Reservation(int id_reservation, int id_eventFK, string Camping_place, DateTime Reservation_startdate, DateTime Reservation_enddate, char Paymentstate)
        {
            this.id_reservation = id_reservation;
            this.id_eventFK = id_eventFK;
            this.camping_place = Camping_place;
            this.paymentState = Paymentstate;
            this.reservation_startdate = Reservation_startdate;
            this.reservation_enddate = Reservation_enddate;
            reservationusers = new List<User>();
        }
        public Reservation()
        {
            reservations = new List<Reservation>();
        }
        public List<Reservation> RequestReservations(int event_Id)
        {
            DatabaseConnection con = new DatabaseConnection();
            string Querry = "SELECT id_reservation,id_eventFK,id_campingPlaceFK,startdate,endDate,paymentState FROM ICT_RESERVATION WHERE id_EventFK = " + Convert.ToString(event_Id);
            Reservation reservation;
            OracleDataReader reader = con.SelectFromDatabase(Querry);

            while (reader.Read())
            {
                reservation = new Reservation(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetDateTime(4), reader.GetDateTime(5), reader.GetChar(6));
                reservations.Add(reservation);
            }

            reader.Dispose();

            return reservations;
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
