using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Threading;

namespace Server
{
    [ServiceContract]
    interface IContract
    {
        [OperationContract(Name = "ClickBtn")]
        void Click();
        [OperationContract(Name = "ClickPhoto")]
        int Click(int k);
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
