using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ejer1
{
    internal class Program
    {
       static List<Empleado> empleados = new List<Empleado>();
        static int posicion = 0;

        public static void anadirEmpleado()
        {
            Console.WriteLine("Dame el nombre del Empleado");
            string nombre = Console.ReadLine();
            Console.WriteLine("Dame el salario del Empleado");
            int salario = int.Parse(Console.ReadLine());

            empleados.Add(new Empleado(nombre, salario));
            posicion += 1;

        }
        public static void MostrarHorasExtra()
        {
            int horas = 0;
            foreach (Empleado empleado in empleados)
            {
                horas += empleado.horasExtra;
            }

            Console.WriteLine("El total de horas extra de todos los empleados es: " + horas);
        }
        public static  void InformeEmpleado()
        {
            foreach (Empleado empleado in empleados)
            {
                Console
                .WriteLine("EMPLEADO " + posicion + "=>  Nombre: " + empleado.nombre +
                " Salario: " +  empleado.salarioSinExtras + " Horas extra: " + empleado.horasExtra +
                " Salario total: " +  empleado.CalculaSalarioTotal());

            }
        }
        public static void anadirExtras()
        {
            Console.WriteLine("Dame el nombre del Empleado");
            string nombre = Console.ReadLine();
            foreach (Empleado empleado in empleados)
            {
                if (nombre.Equals(empleado.nombre))
                {
                    Console.WriteLine("Dame el numero de horas extra que ha hecho");
                    int horas = int.Parse(Console.ReadLine());
                    empleado.HaceHorasExtra(horas);
                }
               
            }
            
        }
        static void Main(string[] args)
        {
            int eleccion;
            do
            {
                Console.WriteLine("ESTE ES EL MENU DE ADMINISTRACIÓN \n" +
                "1) Dar de alta a un nuevo empleado\n" +
                "2) Calcular Horas Extra totales de todos los empleados\n" +
                "3) Mostrar Informe de todos los empleados\n" +
                "4) Insetar Horas Extra");
                eleccion = int.Parse(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        anadirEmpleado();
                        break;
                    case 2:
                        MostrarHorasExtra();
                        break;
                    case 3:
                        InformeEmpleado();
                        break;
                    case 4:
                        anadirExtras();
                        break;
                }
            } while (eleccion > 1 || eleccion < 4);


        }


            }
        public class Empleado
        {
            public string nombre;
            public int horasExtra;
            public int salarioSinExtras;


            public Empleado(string nombre,  int salarioSinExtras)
            {
                this.nombre = nombre;
                this.horasExtra = 0;
                this.salarioSinExtras = salarioSinExtras;
            }
            public int gethorasExtra => horasExtra;
            public string getnombre => nombre;

            public int getsalarioSinExtras => salarioSinExtras;

            public void HaceHorasExtra(int horas)
            {
                horasExtra += horas;
           
            }
            public double CalculaSalarioTotal()
            {

                return salarioSinExtras + 25*horasExtra;
            }
        }
    }


