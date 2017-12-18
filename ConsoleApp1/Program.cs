using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference.ServiceSoapClient client = new ServiceReference.ServiceSoapClient();
            Console.WriteLine(client.Fibonacci(10).ToString());
        }
    }
}
