using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime un numero");
            double numero = double.Parse(Console.ReadLine());

            double vAbs = Math.Abs(numero);
           
            Console.WriteLine("El valor absoluto de "+numero+" es "+vAbs);

            double pot = numero *numero*numero;

            Console.WriteLine("El numero "+numero+" elevado al cubo es: "+pot);

            double raiz = Math.Sqrt(numero);

            Console.WriteLine("La raíz del numero " + numero + " es " + raiz);

            double seno = Math.Sin(numero);

            Console.WriteLine("El seno de " + numero + " es " + seno);

            double coseno = Math.Cos(numero);

            Console.WriteLine("El seno de " + numero + " es " + coseno);

            const int n = 10;

            double mayor = Math.Max(numero, n);

            Console.WriteLine("El numero mayor comparado con 10 es " + mayor);

            double menor = Math.Max(numero, n);

            Console.WriteLine("El numero menor comparado con 67 es " + menor);







        }
    }
}
