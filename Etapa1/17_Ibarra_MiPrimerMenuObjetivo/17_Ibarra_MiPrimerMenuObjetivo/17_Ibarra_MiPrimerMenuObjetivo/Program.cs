using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Ibarra_MiPrimerMenuObjetivo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            Console.WriteLine("¡Bienvenido al prograna!");

            Console.WriteLine("---MENÚ---");
            Console.WriteLine("");
            Console.WriteLine("-Opción 1 ");
            Console.WriteLine("-Opción 2 ");
            Console.WriteLine("-Opcón 3 ");
            Console.WriteLine("-Opción 4 ");
            Console.WriteLine("Salir ");
            String Opcion;
            

            while (!salir)
            {
                Console.WriteLine("Seleccione una opción");
                Opcion = Console.ReadLine();
                if(Opcion == "1")
                {
                    Console.WriteLine("Recargar con tarjeta de credito o debito");
                    
                } else if (Opcion == "2")
                {
                    Console.WriteLine("Recargar con tarjeta prepaga");
                    
                } else if ( Opcion == "3")
                {
                    Console.WriteLine("1 GB Internet x 7 dias($ 1.300)");
                    

                }
                else if (Opcion == "4")
                {
                    Console.WriteLine("1 GB Internet x 1 día ($ 900) ");
                    
                }  else if ( Opcion == "5")
                {
                    Console.WriteLine("¡¡Hasta luego!!");
                    
                    salir = true;
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción del munú");
                    
                }



            }






            Console.ReadKey();

        }
    }
}
