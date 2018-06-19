using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            string y = "Yehoshua";
            y.Replace("Y", "Z");
            Console.WriteLine(y);// will still output Yehoshua because strings are immutable so what is really happening 
                                 // by replace is a new string is being created but not catching that new string and printint out the old string
            Console.ReadKey(true);

            string a = "Yehoshua";
            a = a.Replace("Y", "Z");
            Console.WriteLine(a);
            Console.ReadKey(true);
        }
    }
}
