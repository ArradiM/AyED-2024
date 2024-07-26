// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el número de estudiantes: ");
        int n = int.Parse(Console.ReadLine());

        object[,] estudiantes = new object[n, 3];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nIngrese los datos del estudiante " + (i + 1));

            Console.Write("Nombre: ");
            estudiantes[i, 0] = Console.ReadLine();

            Console.Write("Edad: ");
            estudiantes[i, 1] = int.Parse(Console.ReadLine());

            Console.Write("Calificación: ");
            estudiantes[i, 2] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nDatos de los estudiantes:");
        Console.WriteLine("Nombre\tEdad\tCalificación");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(estudiantes[i, 0] + "\t" + estudiantes[i, 1] + "\t" + estudiantes[i, 2]);
        }

        Console.ReadKey();
    }
}
