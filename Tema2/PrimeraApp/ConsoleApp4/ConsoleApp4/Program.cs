using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime el precio del articulo");

            int precio = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuántos llevas?");
            int cant = int.Parse(Console.ReadLine());

            int total = precio * cant;

            Console.WriteLine("Me debes " +total);
        }
    }
}
