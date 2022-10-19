using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "this is sample text there";
            str2.Trim();
            str2.TrimStart();
            str2.TrimEnd();

            Console.WriteLine(str1.Length);
            Console.WriteLine(str2.Length);

            string str3 = string.Concat(str1, " ", str2);
            Console.WriteLine(str3);

            Console.WriteLine(str3.ToUpper());
            Console.WriteLine(str3.ToLower());

            char[] ch = str3.ToCharArray();
            foreach(var item in ch)
              {
                Console.WriteLine(item);
              }

            bool result = str3.StartsWith("hello");
            Console.WriteLine(result);

            bool result1 = str3.EndsWith("text");
            Console.WriteLine(result1);
        }
    }
}
