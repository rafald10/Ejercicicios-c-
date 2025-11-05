using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el primer numero");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el segundo numero");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el tercer numero");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el cuarto numero");
            int n4 = int.Parse(Console.ReadLine());


            int suma = n1 + n2;
            Console.WriteLine("La suma de los primeros es: " + suma);

            int pro = n3 * n4;
            Console.WriteLine("El producto de los últimos es: "+pro);
        }
    }
}
