using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJER10_FUNC
{
    internal class Program
    {

        public class Banco
        {
            private Cliente cliente1;
            private Cliente cliente2;
            private Cliente cliente3;

            public Banco()
            {
                cliente1 = new Cliente("Juan");
                cliente2 = new Cliente("María");
                cliente3 = new Cliente("Pedro");
            }

            
            public void Operar()
            {
                cliente1.Ingresar(1500);
                cliente2.Ingresar(2000);
                cliente3.Ingresar(1800);

                cliente1.Sacar(500);
                cliente2.Sacar(300);
             
            }

            // Muestra estado del banco y clientes
            public void ObtenerEstado()
            {
                double totalBanco = cliente1.GetCantidadTotal() + cliente2.GetCantidadTotal() + cliente3.GetCantidadTotal();

                Console.WriteLine($"\n=== Estado del Banco ===");
                Console.WriteLine($"Total acumulado en el banco: {totalBanco:C2}\n");

                Console.WriteLine(cliente1.MostrarInfo());
                Console.WriteLine(cliente2.MostrarInfo());
                Console.WriteLine(cliente3.MostrarInfo());
            }

           
            public static void Main(string[] args)
            {
                Banco banco = new Banco();
                banco.Operar();
                banco.ObtenerEstado();

                Console.WriteLine("\nSimulación terminada.");
            }
        }
        class Cliente
        {
            private string nombre;
            private int cantidadTotal;

            public Cliente(string nombre)
            {
                this.nombre = nombre;
                this.cantidadTotal = 0;
            }


            public void Ingresar(int cantidad)
            {
                if (cantidad > 0)
                {
                    cantidadTotal += cantidad;
                }
                else
                {
                    Console.WriteLine("La cantidad a ingresar debe ser mayor que 0.");
                }
            }
            public void Sacar(int cantidad)
            {
                cantidadTotal -= cantidad;
            }

            public int GetCantidadTotal()
            {
                return cantidadTotal;
            }
            public String GetNombre()
            {
                return nombre;
            }

            public String MostrarInfo()
            {
                return "El cliente"+ GetNombre()+" tiene " + GetCantidadTotal();
            }
        }
    }
}
