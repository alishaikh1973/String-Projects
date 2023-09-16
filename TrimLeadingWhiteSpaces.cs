using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.String
{
    internal class TrimLeadingWhiteSpaces
    {
        static void Main(string[] args)
        {
            string str = "   Hello World   ";
            string str1 = "Hello";
            string str2 = "World";
            string result = string.Concat(str1 + str2);
            Console.WriteLine("string after removing all the white spaces:" + str.TrimStart());
            Console.WriteLine(result);



        }
    }
}
