using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Ibarra_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            while (num <= 100)
            {
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(num);
                }

                num++;
            }

            Console.ReadKey();
        }
    }
}
