using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el String");
            String str = Console.ReadLine();

            String txt = "www";
            Boolean hola = false;

            if (str.StartsWith(txt))
            {
                hola = true;
            }

            Console.WriteLine(hola);
        }
    }
}
