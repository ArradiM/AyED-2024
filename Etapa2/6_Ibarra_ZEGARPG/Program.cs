// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Ingrese la cantidad de elementos (objetos) que desea analizar: ");
        int cantelementos = int.Parse(Console.ReadLine());

        
        Console.WriteLine("Ingrese el valor mínimo que deben tener los objetos para ser considerados en el filtro: ");
        int valormin = int.Parse(Console.ReadLine());

        
        int[] elementos = new int[cantelementos];

        
        for (int i = 0; i < cantelementos; i++)
        {
            Console.WriteLine("Ingrese el valor del objeto N° " + (i + 1) + ": ");
            elementos[i] = int.Parse(Console.ReadLine());
        }

        
        Console.WriteLine("Las posiciones de los objetos cuyo valor es mayor al número especificado son:");
        for (int i = 0; i < cantelementos; i++)
        {
            if (elementos[i] > valormin)
            {
                Console.WriteLine("Objeto en la posición " + (i + 1) + " con valor " + elementos[i]);
            }
        }

        
        Console.ReadKey();
    }
}

