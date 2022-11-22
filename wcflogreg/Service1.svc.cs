using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using wcflogreg.Queries;

namespace wcflogreg
{

    public class Service1 : IService1
    {
        /*
        public string rankCheck(Users.user user)
        {
            Read r = new Read();    
            
            return 
        }
        */
        public string regCheck(Users.user user)
        {
            Read r=new Read();
            return r.authentication(user.uname, user.pwd);
        }

        public string registration(Users.user user)
        {
            Create r = new Create();
            if (r.regUser(user) > 0)
                return "Sikeres regisztrálció";
            else
                return "Hiba a regisztálció során";
            
        }
    }
}
