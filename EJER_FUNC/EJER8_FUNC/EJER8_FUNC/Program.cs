using System;

class Program
{
    
    static int SumarDigitos(int numero)
    {
        int suma = 0;
        numero = Math.Abs(numero); 

        while (numero > 0)
        {
            suma += numero % 10;  
            numero /= 10;         
        }

        return suma;
    }

    static void Main()
    {
        Console.Write("Introduce un número entero: ");
        int num = int.Parse(Console.ReadLine());

        int resultado = SumarDigitos(num);

        Console.WriteLine($"La suma de los dígitos de {num} es: {resultado}");
    }
}

