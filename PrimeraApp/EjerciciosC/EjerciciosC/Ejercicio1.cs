using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int hamburgesa = 13;
            const int patatas = 3;
            const int bebidas = 2;

            Console.WriteLine("Cuantas hamburguesas quieres");
            int nHam = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantas patatas quieres");
            int nPat = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantas bebidas quieres");
            int nBeb = int.Parse(Console.ReadLine());

            int precio = (nHam * hamburgesa) + (nBeb * bebidas) + (nPat * patatas);

            Console.WriteLine("El precio final es de " + precio + " euros");
        }
    }
}
