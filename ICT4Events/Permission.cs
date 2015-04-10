using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events
{
    //teun van der wijst
    public class Permission
    {
        private string name;
        private int permission_value;

        public int Permission_Value
        {
            get { return permission_value; }
            set { permission_value = value; }
        }
        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public Permission(string name, int permission_value)
        {
            this.name = name;
            this.permission_value = permission_value;
        }
    }
}
