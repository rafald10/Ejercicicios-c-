using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer9_func
{
    internal class Program
    {
        static int PosicionMenor()
        {
            
            int[] numeros = { 12, 4, 9, 3, 7, 15 };

            int menor = numeros[0];
            int pos = 0;

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                    pos = i;
                }
            }

            return pos;
        }

        static void Main()
        {
            Console.WriteLine("La posición del número menor es: " + PosicionMenor());
        }
    }
}

