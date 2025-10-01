using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ej1_func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el tamaño del array");
            int tamano = int.Parse(Console.ReadLine());


            int suma = 0;
            int[] array = new int[tamano];

            for (int i = 0; i < tamano; i++)
            {
                Console.WriteLine("Dame el numero en la posicion " + i);
                int numero = int.Parse(Console.ReadLine());

                array[i] = numero;

                suma = suma + numero;

            }
            int media = suma / tamano;


            Console.WriteLine("la suma es " + suma + " y la media es " + media);
        }
    }
}
