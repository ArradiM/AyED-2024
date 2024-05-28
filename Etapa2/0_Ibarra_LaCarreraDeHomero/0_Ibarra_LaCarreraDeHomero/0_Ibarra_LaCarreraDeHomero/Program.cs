using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Ibarra_LaCarreraDeHomero
{
    class Program
    {
        static void Main(string[] args)
        {
            int obs;
            Console.WriteLine("Ingrese la cantidad de obstáculos");
            obs = int.Parse(Console.ReadLine());
            int[] vector = new int[obs];



            for (int i = 0; i < obs; i++)
            {
                string rs;
                Console.WriteLine("OBSTACULO" + i + ",lo supera?");
                rs = Console.ReadLine();


                if (rs == "si")
                {
                    vector[i] += 10;
                }
                else if (rs == "no")
                {
                    vector[i] -= 5;
                }
                else
                {
                    Console.WriteLine("ERROR");
                    i--;

                }
                
            }
            int acumulador = 0;

            for (int i = 0; obs > i; i++)
            {
                acumulador += vector[i];
                
                
            }
            Console.WriteLine("Tu puntaje total: " + acumulador);

            Console.ReadKey();
        }
    }
}
