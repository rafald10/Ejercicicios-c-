using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJER3_CLASES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cancion cancion1 = new Cancion("Sevilla", "JC Reyes");
            Cancion cancion2 = new Cancion("Amor y Mafia", "JC Reyes");
            Cancion cancion3 = new Cancion("a 300", "JC Reyes");
            Cancion cancion4 = new Cancion("Brigantes", "JC Reyes");
            Cancion cancion5 = new Cancion("N4", "JC Reyes");

            CD nuevoCD = new CD();
            nuevoCD.agrega(cancion1);
            nuevoCD.agrega(cancion2);
            nuevoCD.agrega(cancion3);
            nuevoCD.agrega(cancion4);

            nuevoCD.grabaCancion(6,cancion5);

            nuevoCD.elimina(2);
            nuevoCD.mostrar();

        }
    }
    public class Cancion
    {
        protected string titulo;
        protected string autor;

        public Cancion(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }

        public Cancion() {
            this.autor = "";
            this.titulo = "";

        }
        public string dameTitlo()
        {
            return titulo;

        }
        public string dameAutor()
        {
            return autor;
        }
        public void ponTitulo(string titulo) {
            this.titulo = titulo;
        }
        public void ponAutor(string autor)
        {
            this.autor = autor;
        }
        public string toString()
        {
            return dameTitlo() + dameAutor();
        }

    }
    public class CD
    {
        protected Cancion[] canciones;
        protected int contador;

        public CD()
        {
            this.canciones = new Cancion[10];
        }
        public int numeroCanciones()
        {
            return contador;
        }
        public void dameCancion(int posicion)
        {
            Console.WriteLine("La canción en esa posición es " + canciones[posicion]);

        }
        public void grabaCancion(int posicion, Cancion cancion)
        {
            canciones[posicion] = cancion;

        }
        public void agrega(Cancion cancion)
        {
            canciones[contador] = cancion;
            contador += 1;
        }

        public void elimina(int posicion)
        {
            canciones[posicion] = null;
            
        }
        public void mostrar()
        {
            for(int i = 0; i < contador; i++)
            {

                Console.WriteLine(canciones[i].ToString());
                
               
                
            }
        }

    }



}
