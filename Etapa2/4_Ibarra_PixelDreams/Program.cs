// See https://aka.ms/new-console-template for more information
using System;


class Program
{
    static void Main()
    {
        int participantes;
            Console.WriteLine("Ingrese la cantidad de participantes ");
            participantes = int.Parse(Console.ReadLine());
            int[] cantpart = new int[participantes];


        for (int i = 0; i < participantes; i++)
        {
            Console.WriteLine("Ingrese los puntajes del participante N° " + (i+1));
            cantpart[i] += int.Parse(Console.ReadLine());
        }


        Console.WriteLine("ORDEN MAYOR A MENOR: ");




        for (int i = 0; i < cantpart.Count() - 1; i++)
        {
            for (int j = 0; j < cantpart.Count() - i - 1; j++)
            {
                if (cantpart[j] < cantpart[j + 1])
                {
                    int temp = cantpart[j];
                    cantpart[j] = cantpart[j + 1];
                    cantpart[j + 1] = temp;


                }
            }
        }
        for (int i = 0; i < participantes; i++)
        {
            Console.WriteLine(cantpart[i]);
        }


        Console.WriteLine("Primer lugar: " + cantpart[0]);


        Console.WriteLine("Ultimo lugar: " + cantpart[participantes - 1]);


        Console.ReadKey();
    }
}

