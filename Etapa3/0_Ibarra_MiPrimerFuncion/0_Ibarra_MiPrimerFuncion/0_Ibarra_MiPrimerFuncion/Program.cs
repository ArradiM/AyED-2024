using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Ibarra_MiPrimerFuncion
{
    class Program

    {
        static string n (string x)
        {
            x = "Hola " + x;
            return x;
        }
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("Como te llamas?");
            nombre = Console.ReadLine();
            Console.WriteLine(n(nombre));

            Console.ReadKey();
        }
    }
}
