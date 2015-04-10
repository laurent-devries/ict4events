using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events
{
    //teun van der wijst
    public class User
    {
        private int id = 0;
        private int id_user;
        private int rfid_tag;
        private string real_name;
        private DateTime birth_date;
        private string email;
        private string city;
        private int phone_number;
        private string loginname;
        private string username;
        private string password;
        private string profile_pic;
        private string summary;
        private bool present;

        public bool Present
        {
            get { return present; }
            set { present = value; }
        }
        

        public string Summary
        {
            get { return summary; }
            set { summary = value; }
        }
        

        public string Profile_Pic
        {
            get { return profile_pic; }
            set { profile_pic = value; }
        }
        

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        

        public string MyProperty
        {
            get { return username; }
            set { username = value; }
        }
        

        public string Login_Name
        {
            get { return loginname; }
            set { loginname = value; }
        }
        

        public int Phone_Number
        {
            get { return phone_number; }
            set { phone_number = value; }
        }
        

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        

        public DateTime Birth_Date
        {
            get { return birth_date; }
            set { birth_date = value; }
        }
        

        public string Real_Name
        {
            get { return real_name; }
            set { real_name = value; }
        }
        

        public int RFID_Tag
        {
            get { return rfid_tag; }
            set { rfid_tag = value; }
        }
        

        public int ID_User
        {
            get { return id_user; }
            set { id = value; }
        }
        
        public User(int rfid_tag, string real_name, DateTime birth_date, string email, string city, int phone_number, string loginname, string username, string password, string profile_pic, string summary, bool present)
        {
            id += 1;
            this.real_name = real_name;
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

        public void CheckIn()
        {
            // event.participants.add(user)
        }

        public void CheckOut()
        {
            // event.participants.remove(user)
        }

        public Event GetEvents()
        {
            //return alle events
        }

        public void Borrow()
        {
            // borrow shit
        }
    }
}
