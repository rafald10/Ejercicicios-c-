using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJER4_FUNC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());

            if (EsPrimo(numero))
                Console.WriteLine("El "+numero+ " es un número primo.");
            else
                Console.WriteLine("El " + numero + " NO es un número primo.");
        }

        static bool EsPrimo(int n)
        {
            if (n <= 1) return false; 
            if (n == 2) return true;  
            if (n % 2 == 0) return false; 

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        
        }
    }
}
