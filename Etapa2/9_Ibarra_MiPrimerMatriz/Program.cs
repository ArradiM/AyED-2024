// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese n para el número de filas ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese m para el número de columnas ");
        int m = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, m];

        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matriz[i, j] = 0;
            }
        }

        Console.WriteLine("\nMATRIZ:");

        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}

