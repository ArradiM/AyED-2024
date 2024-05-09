using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ibarra_BienvenidoACiudad
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("¿Cual es tu nombre?");
            nombre = Console.ReadLine();
            string ciudad;
            Console.WriteLine("Dime el nombre de una ciudad");
            ciudad = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + ", bienvenido a " + ciudad);

            Console.ReadKey();
        }
    }
}
