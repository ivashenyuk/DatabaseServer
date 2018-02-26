using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Threading;
using components;
using Newtonsoft.Json.Linq;

namespace Server
{
    class ServiceUser : IUsers
    {
        Context context = new Context();

        public List<JArray> GetUsers()
        {
            var users = from user in context.Users
                        select user;

            List<JArray> listUsers = new List<JArray>();
            listUsers.Add(JArray.FromObject(users));

            return listUsers;
        }
        public void AddUser(string userName, string lastname, DateTime birthday)
        {
            //TODO: You will have to write here!
        }
        public void EditUser(int id, string userName, string lastname, DateTime birthday)
        {

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            IUsers service = new ServiceUser();

            var tmp = service.GetUsers();

            foreach (var item in tmp)
            {
                Console.WriteLine(item);
            }
           
                       

            Console.ReadLine();
        }
    }
}
