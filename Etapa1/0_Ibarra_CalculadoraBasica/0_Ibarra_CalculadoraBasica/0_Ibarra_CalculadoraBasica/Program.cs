using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Ibarra_CalculadoraBasica
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

            Console.WriteLine("la suma es: " + (num1 + num2));
            Console.WriteLine("la resta es: " + (num1 - num2));
            Console.WriteLine("la multiplicacion es: " + (num1 * num2));
            Console.WriteLine("la division es: " + (num1 / num2));
            Console.WriteLine("el resto es: " + (num1 % num2));


            Console.ReadKey();
        }
    }
}
