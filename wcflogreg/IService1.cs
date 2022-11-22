using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using static wcflogreg.Users;

namespace wcflogreg
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]

        [WebInvoke(Method = "*",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "regCheck")]

        string regCheck(user user);

        [OperationContract]

        [WebInvoke(Method = "*",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "registration")]

        string registration(user user);

        /*
        [OperationContract]

        [WebInvoke(Method = "*",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "rankCheck")]

        string rankCheck (user user);

        */

    }
}
