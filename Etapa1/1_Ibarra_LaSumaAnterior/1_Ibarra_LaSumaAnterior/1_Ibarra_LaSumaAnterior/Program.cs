using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Ibarra_LaSumaAnterior
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Escriba un numero");
            num1 = int.Parse(Console.ReadLine());
            int num2;
            Console.WriteLine("otro");
            num2 = int.Parse(Console.ReadLine());
            int num3;
            Console.WriteLine("otro");
            num3 = int.Parse(Console.ReadLine());

            int suma;
            suma = (num1 + num2 + num3);

            Console.WriteLine("La suma de los tres es: " + (suma));

            Console.ReadKey();

        }
    }
}
