using System;
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

        public User(int id_user, string rfid_tag, string first_name, string sur_name, DateTime birth_date, string email, string city, string phone_number, string loginname, string username, string password, string profile_pic, string summary, char present, string country)
        {
            this.id_user = id_user;
            this.rfid_tag = rfid_tag;
            this.first_name = first_name;
            this.sur_name = sur_name;
            this.birth_date = birth_date;
            this.email = email;
            this.city = city;
            this.phone_number = phone_number;
            this.loginname = loginname;
            this.username = username;
            this.password = password;
            this.profile_pic = profile_pic;
            this.summary = summary;
            this.present = present;
            this.country = country;
        }
        public User()
        {
            userList = new List<User>();
        }
        public List<User> RequestUsers()
        {
            DatabaseConnection con = new DatabaseConnection();
            string Querry = "SELECT ID_USER, RFIDTAG, FIRSTNAME, SURNAME, BIRTHDATE, EMAIL, CITY, CELLPHONENUMBER, LOGINNAME, USERNAME, PASSWORDUSER, PROFILEPIC, SUMMARYUSER, PRESENTUSER, COUNTRY  FROM ICT4_USER";

            OracleDataReader reader = con.SelectFromDatabase(Querry);
            User user;
            while (reader.Read())
            {
                user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), Convert.ToChar(reader.GetString(13)),reader.GetString(14));
                userList.Add(user);
            }
            
            reader.Dispose();

            return userList;
        }

        public User LoginUser(string userName, string password)
        {

            try
            {
                DatabaseConnection con = new DatabaseConnection();
                string Querry = "SELECT ID_USER, RFIDTAG, FIRSTNAME, SURNAME, BIRTHDATE, EMAIL, CITY, CELLPHONENUMBER, LOGINNAME, USERNAME, PASSWORDUSER, PROFILEPIC, SUMMARYUSER, PRESENTUSER FROM ICT4_USER";

                OracleDataReader reader = con.SelectFromDatabase(Querry);
                User user;
                while (reader.Read())
                {
                    user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), Convert.ToChar(reader.GetString(13)), reader.GetString(14));
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
                string Querry = "SELECT ID_USER, RFIDTAG, FIRSTNAME, SURNAME, BIRTHDATE, EMAIL, CITY, CELLPHONENUMBER, LOGINNAME, USERNAME, PASSWORDUSER, PROFILEPIC, SUMMARYUSER, PRESENTUSER, country FROM ICT4_USER WHERE rfidtag = " + "'" + rfid + "'";

                OracleDataReader reader = con.SelectFromDatabase(Querry);
                User user;
                while (reader.Read())
                {
                    user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), Convert.ToChar(reader.GetString(13)), reader.GetString(14));
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
