using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.String
{
    internal class OccurenceofChar
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            char ch = 'l';
            int freq = 0;
            foreach (char c in str) {
                if (c == ch)
                {
                    freq++;

                }
            }
            Console.WriteLine( freq);


        }
    }
}
