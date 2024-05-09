using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Ibarra_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Escribe un numero:");
            num = int.Parse(Console.ReadLine());

            while (num >= 0)
            {
                Console.WriteLine(num);
                num--;
            }

            Console.ReadKey();
        }
    }
}
