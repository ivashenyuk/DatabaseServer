using System;
using System.Collections.Generic;
using System.ServiceModel;
namespace components
{

    [ServiceContract]
    public interface IUsers
    {
        [OperationContract]
        List<User> GetUsers();
        [OperationContract]
        void AddUser(User _user);
        [OperationContract]
        void EditUser(User _user);
    }

}
