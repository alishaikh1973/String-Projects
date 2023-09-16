using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.String
{
    internal class FirstOcccurenceofChar
    {
        static void Main(string[] args)
        {
            string str = "HELLO$WORLD";
            Console.WriteLine(str.IndexOf('L') + "First Occurence of L");
            char[] ch=str.ToCharArray();
            int cnt = 0;
            for(int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'L')
                {
                    cnt++;
                }
            }
            Console.WriteLine($"Occurence of L = {cnt}");

        }
    }
}
