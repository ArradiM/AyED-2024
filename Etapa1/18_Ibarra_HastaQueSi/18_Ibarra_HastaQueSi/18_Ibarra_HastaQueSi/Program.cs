using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Ibarra_HastaQueSi
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta = ""; 
            
            Console.WriteLine("DIGA SI PARA CONTINUAR");
            
            while (respuesta != "SI")
            {
                Console.WriteLine("¿Desea terminar el programa?");
                respuesta = Console.ReadLine();

                if (respuesta != "SI")
                {
                    Console.WriteLine("Respuesta incorrecta. Por favor, responda SI para terminar el programa.");
                }
            }

            Console.WriteLine("¡Hasta la vista!");
            Console.ReadKey();
        }
    }
}
