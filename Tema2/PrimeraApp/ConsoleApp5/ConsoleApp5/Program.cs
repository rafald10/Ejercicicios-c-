using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame nota examen 1");
            double ex1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame nota examen 2");
            double ex2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame nota trabajo en clase");
            double trCl = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame nota actitud");
            double act = int.Parse(Console.ReadLine());


            double examenes = ((ex1 + ex2)/ 4);

            trCl = trCl * 0.3;

            act = act * 0.2;

            double notafinal = trCl + act + examenes;

            Console.WriteLine("Tu nota final es: " +notafinal);


        }
    }
}
