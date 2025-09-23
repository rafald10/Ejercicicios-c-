using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el lado del cuadrado");
            int lado = int.Parse(Console.ReadLine());

            int perimetro = lado * 4;
            Console.WriteLine("El perímetro es "+perimetro);
        }
    }
}
