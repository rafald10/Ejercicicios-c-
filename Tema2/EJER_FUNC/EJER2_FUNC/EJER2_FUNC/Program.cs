using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EJER2_FUNC
{
    internal class Program
    {
        static String contarBlanco(String cadena)
        {

            int blancos = 0;

            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == ' ')
                {
                    blancos = blancos + 1;
                }
            }
            return "Tiene " + blancos + " espacios en blanco";
        }
        static String contarCaracteres(String cadena)
        {

            return "El número de caracteres es " + cadena.Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dame una cadena y te cuento el numero de espacios en blanco");
            String cadena = Console.ReadLine();

            Console.WriteLine(contarCaracteres(cadena));
            Console.WriteLine(contarBlanco(cadena));
        }
        
    }
}
