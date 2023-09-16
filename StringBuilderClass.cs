using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.String
{
    internal class StringBuilderClass
    {
        static void Main(string[] args)
        {
            string str1 = "Hello to all";
            Console.WriteLine(str1);
            Console.WriteLine(str1.GetHashCode());
            str1 = str1  +  "Good Morning";
            Console.WriteLine(str1);
            Console.WriteLine(str1.GetHashCode());
            Console.WriteLine("------String Builder Class-------");
            StringBuilder stringBuilder = new StringBuilder("Hello to all");
            Console.WriteLine(stringBuilder);
            Console.WriteLine(stringBuilder.GetHashCode());
            stringBuilder.Append("Good Morning");
            Console.WriteLine(stringBuilder);
            Console.WriteLine(stringBuilder.GetHashCode());
            stringBuilder.Remove(4, 5);
            Console.WriteLine(stringBuilder);
            stringBuilder.Replace('I', 'L');
            Console.WriteLine(stringBuilder);
            stringBuilder.Replace("all", "everyone");
            Console.WriteLine(stringBuilder);
            Console.WriteLine("Capacity="+stringBuilder.Capacity);
            stringBuilder.Clear();
            Console.WriteLine(stringBuilder);


        }
    }
}
