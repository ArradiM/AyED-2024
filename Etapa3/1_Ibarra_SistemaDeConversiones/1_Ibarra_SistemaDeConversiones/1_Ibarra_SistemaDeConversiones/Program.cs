using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Ibarra_SistemaDeConversiones
{
    class Program
    {
        static string decimalB(int num)
        {
            string binario = "";
             while(num > 0)
            {
                binario = (num % 2) +binario;
                num /= 2;
                
            }
            

            return binario;
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero decimal ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("binario: "+decimalB(num1));

            Console.WriteLine("Ingrese numero binario ");
            int num2 = int.Parse(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
