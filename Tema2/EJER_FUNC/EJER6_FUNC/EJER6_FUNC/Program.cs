using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJER6_FUNC
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


            for (int i = 3; i > 0; i++)
            {
                Console.WriteLine("Introduce el usuario: ");
                String usuario = Console.ReadLine();
                Console.WriteLine("Introduce la contraseña: ");
                String contra = Console.ReadLine();

                if (login(usuario, contra))
                {
                    Console.WriteLine("Has entrado");
                    break;
                }
                else
                {
                    Console.WriteLine("Te quedan " + (i - 1) + " intentos");
                }

            }
            



        }
        static bool login(String usuario, String contra)
        {
            if (usuario.Equals("usuario2DAM") && contra.Equals("pass2DAM"))
            {
                return true;

            }

            return false;
        }
    }
}
