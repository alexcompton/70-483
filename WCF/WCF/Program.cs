using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new instance of the service
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            // read in the user input and then feed it to the wcf service
            String str = Console.ReadLine();
            Console.WriteLine(client.GetData(str));

            Console.WriteLine("\n\npress any key to continue...");
            Console.ReadKey();
        }
    }
}
