using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJER3_FUNC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el numero del que quieres el factorial");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("El factorial del numero es " + fact(n));
        }
        static int fact(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * fact(n - 1);
            }

                
        }
    }
}
