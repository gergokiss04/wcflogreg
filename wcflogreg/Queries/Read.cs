using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcflogreg.Queries
{
    public class Read
    {
        Connect c = new Connect();
        public string authentication(string uname, string pwd)
        {
            try
            {
                string qry = "SELECT id,rank,uname,pwd FROM users WHERE uname=@uname AND pwd=@pwd";

                MySqlCommand cmd = new MySqlCommand(qry);
                cmd.Connection = c.connect;
                cmd.Parameters.AddWithValue("uname", uname);
                cmd.Parameters.AddWithValue("pwd", pwd);

                cmd.CommandText = qry;

                MySqlDataReader dr = cmd.ExecuteReader();
                string result = "Nincs regisztrált felhasználó";
                if (dr.HasRows)
                {
                    dr.Read();
                    result=dr.GetInt32("id")+" "+dr.GetInt32("rank");
                }
                

                return result;
            }
            catch (Exception)
            {

                return "Hiba az azonosítás során!";
            }
        }

       
    }
}