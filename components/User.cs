using System;
using System.Runtime.Serialization;

namespace components
{
    [DataContract]
    public class User
    {
        [DataMember]
        int id;
        [DataMember]
        string userName;
        [DataMember]
        string userLastname;
        [DataMember]
        DateTime birthday;
        public User(int id, string userName, string userLastname, DateTime birthday)
        {
            this.id = id;
            this.userName = userName;
            this.userLastname = userLastname;
            this.birthday = birthday;
        }
    }
}
