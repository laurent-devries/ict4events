using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace ICT4Events
{
    //teun van der wijst
    public class User
    {
        
        private static int id = 0;
        private int id_user;
        private int rfid_tag;
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

        public string Sur_Name { get { return sur_name; } set { sur_name = value; } }
        public int RFID_Tag { get { return rfid_tag; } set { rfid_tag = value; } }
        public int ID_User { get { return id_user; } }

        public User(int rfid_tag, string first_name, string sur_name, DateTime birth_date, string email, string city, string phone_number, string loginname, string username, string password, string profile_pic, string summary, char present)
        {
            id_user = id;
            id++;
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
        }
        public User()
        {
            userList = new List<User>();
        }
        public List<User> Requestuser()
        {
            DatabaseConnection con = new DatabaseConnection();
            string Querry = "SELECT * FROM ICT4_USER";

            OracleDataReader reader = con.SelectFromDatabase(Querry);
            User user;
            while (reader.Read())
            {
                //user
                //userList.Add(user);
            }

            reader.Dispose();

            return userList;
        }
    }
}
