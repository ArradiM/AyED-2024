// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int candidatos;
        Console.WriteLine("Ingrese la cantidad de candidatos");
        candidatos = int.Parse(Console.ReadLine());
        int[] cantCandidatos = new int[candidatos];

        for (int i = 0; i < candidatos; i++)
        {
            Console.WriteLine("Ingrese el puntaje del candidato N° " + (i + 1));
            cantCandidatos[i] = int.Parse(Console.ReadLine());

        }

        Console.WriteLine("Ingrese un número entero ");
        int valor = int.Parse(Console.ReadLine());

        Console.WriteLine("Puntajes que son múltiplos de " + valor + ":");
        for (int i = 0; i < cantCandidatos.Length; i++)
        {
            if (cantCandidatos[i] % valor == 0)
            {
                Console.WriteLine("Candidato N° " + (i + 1) + ": Puntaje " + cantCandidatos[i]);
            }else
            {
                Console.WriteLine(cantCandidatos[i] +" No es multiplo de "+ valor);
            }
            
        }



        for (int i = 0; i < cantCandidatos.Length - 1; i++)
        {
            for (int j = 0; j < cantCandidatos.Length - i - 1; j++)
            {
                if (cantCandidatos[j] > cantCandidatos[j + 1])
                {
                    int aux = cantCandidatos[j];
                    cantCandidatos[j] = cantCandidatos[j + 1];
                    cantCandidatos[j + 1] = aux;
                }
            }
        }


        
        Console.WriteLine("ORDEN DE MENOR A MAYOR: ");
        for (int i = 0; i < candidatos; i++)
        {
            Console.WriteLine(cantCandidatos[i]);
        }

        Console.ReadKey();
    }
}




