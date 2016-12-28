using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Xamarin.Forms;

namespace Sage
{
    class DAL : Page
    {
        MySqlConnection conn;
        string myConnectionString;

        public DAL ()
        {
            myConnectionString = "server=66.147.244.168;uid=studepr5_admin;" + "pwd=fN#PD.}~-GGD;database=studepr5_sage;";
        }

        public void OpenDatabaseConnection()
        {
            try
            {
                conn = new MySqlConnection(myConnectionString);
                conn.Open();
                DisplayAlert("Database connected", "You have connected to the database.", "OK");
            }
            catch (MySqlException ex)
            {

                DisplayAlert("Database NOT connected", ex.ToString(), "OK");
            }
        }
    }
}
