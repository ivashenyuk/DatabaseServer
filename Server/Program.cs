using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using components;
using Newtonsoft.Json;

namespace Server
{
    class ServiceUser : IUsers
    {
        Context context = new Context();

        public List<components.User> GetUsers()
        {
            var users = from user in context.Users
                        select user;

            //not fine;
            List<User> listUsers = users.ToList();
            List<components.User> listUsers1 = new List<components.User>();

            foreach (var _user in listUsers)
            {
                listUsers1.Add(new components.User(_user.Id, _user.Name, _user.Lastname, _user.Birthday));
            }
            return listUsers1;
        }
        public void AddUser(components.User _user)
        {
            User user = new User { Id = _user.Id, Name = _user.Name, Lastname = _user.Lastname, Birthday = _user.Birthday };
            context.Users.Add(user);
            context.SaveChanges();
        }
        public void EditUser(components.User _user)
        {
            User currentUser = new User { Id = _user.Id, Name = _user.Name, Lastname = _user.Lastname, Birthday = _user.Birthday };

            var result = from user in context.Users
                         where user.Id == currentUser.Id
                         select user;
            User user1 = (User)result.ToList()[0];
            context.Entry(user1).CurrentValues.SetValues(currentUser);
            context.SaveChanges();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Uri address = new Uri("http://localhost/IUsers");
            BasicHttpBinding binding = new BasicHttpBinding();
            Type contract = typeof(IUsers);

            ServiceHost host = new ServiceHost(typeof(ServiceUser));
            host.AddServiceEndpoint(contract, binding, address);
            host.Open();
            Console.ReadLine();
            host.Close();
        }
    }
}
