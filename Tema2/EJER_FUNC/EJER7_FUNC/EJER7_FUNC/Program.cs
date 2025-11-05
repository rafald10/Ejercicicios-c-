using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJER7_FUNC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime un numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el otro numero: ");
            int b = int.Parse(Console.ReadLine());

            if(esMultiplo(a, b)){
                Console.WriteLine("Los numero son multiplos");
            }
            else
            {
                Console.WriteLine("Los numeros no son multiplos");
            }


        }
        static bool esMultiplo(int a, int b)
        {
            if (a%b == 0 || b%a == 0)
            {
                return true;
            }

            return false;
        }
    }
}
