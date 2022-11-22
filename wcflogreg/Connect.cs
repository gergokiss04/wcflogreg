using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcflogreg
{
    public class Connect
    {
        public MySqlConnection connect;
        public string server;
        public string database;
        public string user;
        public string password;
        public string connectionstring;


        public Connect()
        {
            server = "localhost";
            database = "backenddb";
            user = "root";
            password = "";
            connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "USER=" + user + ";" + "PASSWORD=" + password + ";" + "SslMode=None;";

            connect = new MySqlConnection(connectionstring);

            try
            {
                connect.Open();
                Console.WriteLine("Sikeres csatlakozás!");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}