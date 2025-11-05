using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJER1_CLASES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("Rafa", 5000);

            cuenta.ingresar(2000);
            cuenta.retirar(500);
            cuenta.retirar(3000);
            cuenta.retirar(4000);


        }
        public class Cuenta
        {
            protected string titular;
            protected double cantidad;

            public Cuenta(string titular, double cantidad)
            {
                this.titular = titular;
                this.cantidad = cantidad;
            }
            public Cuenta(string titular) { this.titular = titular; } 

            public double getCantidad() { return cantidad; }
            public string getTitular() { return titular; }

            public void setCantidad(double cantidad) { this.cantidad = cantidad; }

            public void setTitular(string titular) { this.titular = titular; }

            public void ingresar(double cantidad1
                )
            {
                if (cantidad>0)
                {
                    cantidad += cantidad1;
                    Console.WriteLine("Ingreso con éxito, tu cuenta tiene "+cantidad);
                }
                else
                {
                    Console.WriteLine("Cantidad negativa");
                }
            }
            public void retirar(double cantidad2)
            {
                cantidad -= cantidad2;

                if (cantidad<0)
                {
                    cantidad = 0;

                    Console.WriteLine("Retiro realizado de ",+cantidad2+" tu cuenta está a 0");

                    
                }
                else
                {
                    Console.WriteLine("Retiro realizado con éxito tu cuenta tiene " + cantidad + " euros");

                }
            }




        }
    }
}
