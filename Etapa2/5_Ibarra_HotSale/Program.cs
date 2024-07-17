// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la cantidad de productos vendidos durante el Hot Sale: ");
        int productosvendidos=int.Parse(Console.ReadLine());

        int[] productos= new int[productosvendidos];

        for(int i =0;i<productosvendidos;i++){
            Console.WriteLine("Ingrese el precio del producto N° "+(i + 1));
            productos[i] = int.Parse(Console.ReadLine());
        }


        int preciomayor = productos[0];
        int preciomenor = productos[0];


        for (int i = 1; i < productosvendidos; i++)
        {
            if (productos[i] > preciomayor)
            {
                preciomayor = productos[i];
            }
            if (productos[i] < preciomenor)
            {
                preciomenor = productos[i];
            }
        }

        
        Console.WriteLine("El precio más alto registrado durante el evento es: "+ preciomayor);
        Console.WriteLine("El precio más bajo registrado durante el evento es: "+preciomenor);
        
        Console.ReadKey();
    }
}
