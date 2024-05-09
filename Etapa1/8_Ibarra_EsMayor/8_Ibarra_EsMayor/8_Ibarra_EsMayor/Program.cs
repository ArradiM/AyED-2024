using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Ibarra_EsMayor
{
    class Program
    {
        static void Main(string[] args)
        {

            int edad;
            Console.WriteLine("¿cual es tu edad?");
            edad = int.Parse(Console.ReadLine());

            if(edad >= 18)
            {
                Console.WriteLine("eres mayor de edad");
            } 
            else
            {
                Console.WriteLine("eres menor de edad");
            }

            Console.ReadKey();
        }
    }
}
