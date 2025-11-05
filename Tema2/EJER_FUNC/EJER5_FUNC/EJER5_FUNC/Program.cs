using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJER5_FUNC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el numero que quieres elevar");
            int n1 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Dame el numero al que quieres elevar");
            int n2 = int.Parse(Console.ReadLine());

            int OP = 1;

            for (int i = 0; i < n2; i++)
            {
                OP *= n1;
            }

            Console.WriteLine("el RESULTADO ES :"+OP);
        }
    }
}
