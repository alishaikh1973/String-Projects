using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.String
{
    internal class StringSpilt
    {
        static void Main(string[] args)
        {
            string str= "HELLO$WORLD";
            string[] sarr = str.Split("$");
            foreach (string s in sarr)
            {
                Console.WriteLine(s);

            }







        }
    }
}
