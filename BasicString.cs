using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.String
{
    internal class BasicString
    {
        static void Main(string[] args)
        {
            string message = "Hello to all";
            Console.WriteLine(message);
            Console.WriteLine(message.GetHashCode());
            message = message + "Good morning";
            Console.WriteLine(message);
            Console.WriteLine(message.GetHashCode());
            message = message + "Good Day";
            Console.WriteLine(message);
            Console.WriteLine(message.GetHashCode());


        }
    }
}
