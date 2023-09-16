using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.String
{
    internal class StringMethods
    {
        static void Main(string[] args)
        {
            string message = "Hello to all";
            string message2 = "hello to all";
            string str1 = string.Concat(message, " ", message2.TrimEnd());
            Console.WriteLine(str1);
            Console.WriteLine(str1.Trim());
            Console.WriteLine(message2.ToUpper());
            Console.WriteLine(message2.ToLower());
            Console.WriteLine("index - " + message2.IndexOf('o'));
            Console.WriteLine("Last Index-" + message2.LastIndexOf('o'));
            string[] strarr = message2.Split(',');
            char[] ch = message.ToCharArray();
            string str2 = new string(ch);
            Console.WriteLine(str2);
            foreach (char c in ch)
            {
                Console.WriteLine(c);


            }
            foreach (string s in strarr)
            {
                Console.WriteLine(s);
            }
            for (int i = 0; i < message2.Length; i++)
            {
                Console.WriteLine(message2[i]);

            }
        





        }
    }
}
