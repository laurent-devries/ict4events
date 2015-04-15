using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace ICT4Events
{
    public class DatabaseConnection
    {
        private OracleConnection oracleConn;

        private string user = "system";//Wachtwoord van de server
        private string pw = "root";//Wachtwoord van de server

        private void Connect()
        {
            try
            {
                oracleConn = new OracleConnection("User Id=" + user + ";Password=" + pw + ";Data Source=" + "//localhost:1521/XE" + ";");
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        
        public OracleDataReader SelectFromDatabase(string Querry)
        {
            try
            {
                Connect();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = oracleConn;
                cmd.CommandText = Querry;
                cmd.CommandType = CommandType.Text;
                oracleConn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                return reader;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }

        }
    }
}
