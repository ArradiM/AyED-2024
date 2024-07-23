using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ibarra_ElRayoCarreraVeloz
{
    class Program
    {
        static void Main(string[] args)
        {
            int vueltas;
            Console.WriteLine("Ingrese la cantidad de vueltas");
            vueltas = int.Parse(Console.ReadLine());
            int[] vector = new int[vueltas];

            for (int i = 0; i < vueltas; i++)
            {
                
                Console.WriteLine("¿CUANTO DURO LA CARRERA " +( i+1) + "?");
                vector[i] += int.Parse(Console.ReadLine());
                
            }

            
            int acumulador = 0;

            for (int i = 0; vueltas > i; i++)
            {
                acumulador += vector[i];

            }

            int mjvuelta = 0;
            int tiempomin = vector[0];

            for (int i = 0; i < vueltas; i++)
            {
                mjvuelta += vector[i];
                if (vector[i] < tiempomin)
                {
                    tiempomin = vector[i];
                    
                }
            }

            Console.WriteLine("Tu puntaje total: " + acumulador);
            Console.WriteLine("el Promedio " + acumulador / vueltas);
            Console.WriteLine("la mejor vuelta : " +tiempomin);

            Console.ReadKey();
        }

     }
}