using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace wcflogreg.Queries
{
    public class Create
    {
        Connect c=new Connect();

        public int regUser(Users.user user)
        {
            try
            {
                string hostname = Dns.GetHostName();
                string myIp = Dns.GetHostByName(hostname).AddressList[0].ToString();


                string qry = "INSERT INTO `users`( `uname`, `email`, `pwd`, `fullname`, `ipadd`) VALUES (@uname,@email,@pwd,@fullname,@ipadd)";

                MySqlCommand cmd = new MySqlCommand();
                cmd.Parameters.AddWithValue("@uname",user.uname);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@pwd", user.pwd);
                cmd.Parameters.AddWithValue("@fullname", user.fullname);
                cmd.Parameters.AddWithValue("@ipadd", myIp);
                
                cmd.CommandText = qry;
                cmd.Connection = c.connect;
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                return 0;
            }


            
        }
    }
}