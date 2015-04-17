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
    //teun van der wijst
    public class User
    {

        private static int id = 0;
        private int id_user;
        private int permissionFk;
        private string rfid_tag;
        private string first_name;
        private string sur_name;
        private DateTime birth_date;
        private string email;
        private string city;
        private string phone_number;
        private string loginname;
        private string username;
        private string password;
        private string profile_pic;
        private string summary;
        private char present;
        private string country;

        private List<User> userList;

        public char Present { get { return present; } set { present = value; } }
        public string Summary { get { return summary; } set { summary = value; } }
        public string Profile_Pic { get { return profile_pic; } set { profile_pic = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Login_Name { get { return loginname; } set { loginname = value; } }
        public string Phone_Number { get { return phone_number; } set { phone_number = value; } }
        public string City { get { return city; } set { city = value; } }
        public string Email { get { return email; } set { email = value; } }
        public DateTime Birth_Date { get { return birth_date; } set { birth_date = value; } }
        public string First_Name { get { return first_name; } set { first_name = value; } }

        public string Country { get { return country; } set { country = value; } }
        public string Sur_Name { get { return sur_name; } set { sur_name = value; } }
        public string RFID_Tag { get { return rfid_tag; } set { rfid_tag = value; } }
        public int ID_User { get { return id_user; } }
        public int ID_EventFK { get; set; }
        public int ID_ReservationFK { get; set; }
        public string Street { get; set; }
        public string Housenumber { get; set; }

        public int Permissionfk { get { return permissionFk; } set { permissionFk = value; } }

        public User(int id_user, int id_event, int id_reservation, int permission, string first_name, string sur_name, DateTime birth_date, string email, string country, string street, string housenumber, string city, string phone_number, string loginname, string username, string password, string profile_pic, string summary, char present, string rfid_tag)
        {
            this.id_user = id_user;
            ID_EventFK = id_event;
            ID_ReservationFK = id_reservation;
            this.permissionFk = permission;
            this.first_name = first_name;
            this.sur_name = sur_name;
            this.birth_date = birth_date;
            this.email = email;
            this.country = country;
            Street = street;
            Housenumber = housenumber;
            this.city = city;
            this.phone_number = phone_number;
            this.loginname = loginname;
            this.username = username;
            this.password = password;
            this.profile_pic = profile_pic;
            this.summary = summary;
            this.present = present;
            this.present = present;
            this.rfid_tag = rfid_tag;
        }
        public User(int id_user, int id_event, int id_reservation, int permission, string first_name, string sur_name, DateTime birth_date, string email, string country, string street, string housenumber, string city, string phone_number, string loginname, string username, string password, string profile_pic, string summary, char present)
        {
            this.id_user = id_user;
            ID_EventFK = id_event;
            ID_ReservationFK = id_reservation;
            this.permissionFk = permission;
            this.first_name = first_name;
            this.sur_name = sur_name;
            this.birth_date = birth_date;
            this.email = email;
            this.country = country;
            Street = street;
            Housenumber = housenumber;
            this.city = city;
            this.phone_number = phone_number;
            this.loginname = loginname;
            this.username = username;
            this.password = password;
            this.profile_pic = profile_pic;
            this.summary = summary;
            this.present = present;
            this.present = present;

        }
        public User()
        {
            userList = new List<User>();
        }
        public List<User> RequestUsers()
        {
            DatabaseConnection con = new DatabaseConnection();
            string Querry = "SELECT ID_USER, ID_EVENTFK, ID_RESERVATIONFK, id_permissionFK, FIRSTNAME, SURNAME, BIRTHDATE, EMAIL, COUNTRY, STREET, HOUSENUMBER, CITY, CELLPHONENUMBER, LOGINNAME, USERNAME, PASSWORDUSER, PROFILEPIC, SUMMARYUSER, PRESENTUSER, RFIDTAG  FROM ICT4_USER";

            OracleDataReader reader = con.SelectFromDatabase(Querry);
            User user;
            while (reader.Read())
            {
                user = new User(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(15), reader.GetString(16), reader.GetString(17), Convert.ToChar(reader.GetString(18)), reader.GetString(19));
                userList.Add(user);
            }

            reader.Dispose();

            return userList;
        }

        public User LoginUser(string us, string ps)
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                string Querry = "SELECT SELECT ID_USER, ID_EVENTFK, ID_RESERVATIONFK, id_permissionFK, FIRSTNAME, SURNAME, BIRTHDATE, EMAIL, COUNTRY, STREET, HOUSENUMBER, CITY, CELLPHONENUMBER, LOGINNAME, USERNAME, PASSWORDUSER, PROFILEPIC, SUMMARYUSER, PRESENTUSER, RFIDTAG  FROM ICT4_USER WHERE UPPER(LOGINNAME) = '" + us.ToUpper() + "' AND PASSWORDUSER = '" + ps + "'";
                OracleDataReader reader = con.SelectFromDatabase(Querry);
                User user;
                while (reader.Read())
                {
                    user = new User(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(15), reader.GetString(16), reader.GetString(17), Convert.ToChar(reader.GetString(18)), reader.GetString(19));
                    return user;
                }
                MessageBox.Show("Username and password combination does not excist");
                return null;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }

        }

        public User SearchByRfid(string rfid)
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                string Querry = "SELECT SELECT ID_USER, ID_EVENTFK, ID_RESERVATIONFK, id_permissionFK, FIRSTNAME, SURNAME, BIRTHDATE, EMAIL, COUNTRY, STREET, HOUSENUMBER, CITY, CELLPHONENUMBER, LOGINNAME, USERNAME, PASSWORDUSER, PROFILEPIC, SUMMARYUSER, PRESENTUSER, RFIDTAG  FROM ICT4_USER WHERE rfidtag = " + "'" + rfid + "'";

                OracleDataReader reader = con.SelectFromDatabase(Querry);
                User user;
                while (reader.Read())
                {
                    user = new User(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(15), reader.GetString(16), reader.GetString(17), Convert.ToChar(reader.GetString(18)), reader.GetString(19));
                    return user;
                }
                MessageBox.Show("RFID_Tag not in system");
                return null;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }

        }
    }
}
