using System;
using System.Collections.Generic;
using System.ServiceModel;
using Newtonsoft.Json.Linq;

namespace components
{

    [ServiceContract]
    public interface IUsers
    {
        [OperationContract]
        List<JArray> GetUsers();
        [OperationContract]
        void AddUser(string userName, string lastname, DateTime birthday);
        [OperationContract]
        void EditUser(int id, string userName, string lastname, DateTime birthday);
    }

}
