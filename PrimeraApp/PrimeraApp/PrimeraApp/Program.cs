using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            Char operador;
            double resultado = 0;

            Console.WriteLine("Introduce el numero 1: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el numero 2: ");
            numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el operador: ");
            operador = char.Parse(Console.ReadLine());

            if (operador == '+' )
            {
                double suma = numero1 + numero2;
                resultado = suma;
            }
            if (operador == '-')
            {
                double resta = numero1 - numero2;
                resultado = resta;
            }
            if (operador == '*')
            {
                double multiplicacion = numero1 * numero2;
                resultado = multiplicacion;
            }
            if (operador == '/')
            {
                
                double division = numero1 / numero2;
                resultado = division;
                if (numero2 == 0)  resultado = 0 ;
                
            }



            Console.WriteLine("El resultado es "+ resultado);
            
        }
    }
}
