using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Ibarra_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine();
            N = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            int Contador = 1;
            

            while (Contador <= N)
            {
               
                if(Contador % 2 == 0)
                {
                    Console.WriteLine( Contador);
                }
                Contador++;



            }

            Console.ReadKey();
       
        }
    }
}
