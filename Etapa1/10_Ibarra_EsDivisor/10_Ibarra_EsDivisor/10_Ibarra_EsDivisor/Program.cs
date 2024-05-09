using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Ibarra_EsDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            Console.WriteLine("ingresa un numero");
            numero1 = int.Parse(Console.ReadLine());

            int numero2;
            Console.WriteLine("ingresa otro numero");
            numero2 = int.Parse(Console.ReadLine());

            if (numero2 == 0) 
            {
                Console.WriteLine("error");
            }

            else
            {
                Console.WriteLine("el resultado es " + (numero1 / numero2));
            }

            Console.ReadKey();
        }
    }
}
