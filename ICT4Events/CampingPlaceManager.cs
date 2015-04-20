﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Windows.Forms;

namespace ICT4Events
{
    class CampingPlaceManager
    {
        List<CampingPlace> campingPlaceList = new List<CampingPlace>();

        public List<CampingPlace> RequestCampingPlaces(Event e)
        {
            DatabaseConnection con = new DatabaseConnection();
            string Querry = "SELECT * FROM ICT4_CAMPING_PLACE WHERE ID_EVENTFK = " + Convert.ToString(e.ID_Event);

            OracleDataReader reader = con.SelectFromDatabase(Querry);
            CampingPlace campingPlace;
            while (reader.Read())
            {
                campingPlace = new CampingPlace(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4));
                campingPlaceList.Add(campingPlace);
            }

            reader.Dispose();

            return campingPlaceList;
        }

        public List<CampingPlace> RequestFreeCampingPlaces(DateTime startDate, DateTime endDate, Event e)
        {
            DatabaseConnection con = new DatabaseConnection();
            string startMonth;
            string endMonth;
            string startDay;
            string endDay;
            if (startDate.Month < 10)
            {
                startMonth = "0" + Convert.ToString(startDate.Month);
            }
            else
            {
                startMonth = Convert.ToString(startDate.Month);
            }

            if (endDate.Month < 10)
            {
                endMonth = "0" + Convert.ToString(endDate.Month);
            }
            else
            {
                endMonth = Convert.ToString(endDate.Month);
            }

            if (startDate.Day < 10)
            {
                startDay = "0" + Convert.ToString(startDate.Day);
            }
            else
            {
                startDay = Convert.ToString(startDate.Day);
            }

            if (endDate.Day < 10)
            {
                endDay = "0" + Convert.ToString(endDate.Day);
            }
            else
            {
                endDay = Convert.ToString(endDate.Day);
            }

            string Querry = "SELECT CP.ID_CAMPINGPLACE, CP.ID_EVENTFK, CP.PLACENUMBER, CP.MAXPEOPLE, CP.CAMPINGTYPE FROM ICT4_RESERVATION R, ICT4_CAMPING_PLACE CP WHERE CP.ID_CAMPINGPLACE != R.ID_CAMPINGPLACEFK AND ((to_date('" + startDay + startMonth + Convert.ToString(startDate.Year) + "','DDMMYYYY') > R.STARTDATE)  OR  R.ENDDATE > (to_date('" + endDay + endMonth + Convert.ToString(endDate.Year) + "','DDMMYYYY'))) AND R.ID_EVENTFK = CP.ID_EVENTFK AND CP.ID_EVENTFK = " + Convert.ToString(e.ID_Event);
            OracleDataReader reader = con.SelectFromDatabase(Querry);
            CampingPlace campingPlace;
            while (reader.Read())
            {
                campingPlace = new CampingPlace(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4));
                campingPlaceList.Add(campingPlace);
            }
            reader.Dispose();

            return campingPlaceList;

        }
    }
}
