using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Ibarra_LaFiestaDeStitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int invitados;
            Console.WriteLine("Ingrese la cantidad de invitados ");
            invitados = int.Parse(Console.ReadLine());
            int[] vector = new int[invitados];

            for (int i = 0; i < invitados; i++)
            {
                int comida;
                Console.WriteLine("¿Que cantidad consume el invitado "+i + "?");
                comida = int.Parse(Console.ReadLine());

                if (comida >= 1 && comida<=100)
                {
                    
                    vector[i] += comida;

                  
                }
                else
                {
                    Console.WriteLine("error ");
                    i--;
                }
            }
            int acumulador = 0;

            for (int i = 0; invitados > i; i++)
            {
                acumulador += vector[i];


            }
            Console.WriteLine("el porcentaje total es: " + acumulador / invitados);

            Console.ReadKey();
        }
    }
}
