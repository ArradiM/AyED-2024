using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Ibarra_CobrarBeca
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("ingrese su edad");
            edad = int.Parse(Console.ReadLine());

            int ingreso;
            Console.WriteLine("ingrese sus ingresos mensuales");
            ingreso = int.Parse(Console.ReadLine());

            if (edad>=19 && ingreso>=100000)
            {
                Console.WriteLine("podes cobrar");
            }
            else
            {
                Console.WriteLine("no podes cobrar");
            }

            Console.ReadKey();

        }
    }
}
