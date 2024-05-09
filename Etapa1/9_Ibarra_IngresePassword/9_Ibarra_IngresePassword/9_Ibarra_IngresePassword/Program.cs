using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Ibarra_IngresePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string contraseña1 = "mischel1245";
            string contraseña2;
            Console.WriteLine("ingrese su contraseña");
            contraseña2 = Console.ReadLine();


            if (contraseña2 == contraseña1)
            {
                Console.WriteLine("es correcta");
            }
            else
            {
                Console.WriteLine("no es correcta");

            }

            Console.ReadKey();

        }
    }
}
