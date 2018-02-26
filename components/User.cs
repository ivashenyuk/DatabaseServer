using System;
using System.Runtime.Serialization;

namespace components
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int Id;
        [DataMember]
        public string Name;
        [DataMember]
        public string Lastname;
        [DataMember]
        public DateTime Birthday;
        public User(int id, string userName, string userLastname, DateTime birthday)
        {
            this.Id = id;
            this.Name = userName;
            this.Lastname = userLastname;
            this.Birthday = birthday;
        }
    }
}
