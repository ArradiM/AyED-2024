using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Ibarra_PochimonsFuncionales
{
    class Program
    {
        static void Main(string[] args)
        {

            string pochimon;
            string tipo;
            int nivel;
            int estado = 0;
            int investigador = 0;
            int contador = 0;

            object[,] cantpochimons = new object[76, 6];

            for (int i = 0; i < 76; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    cantpochimons[0, 0] = "Fila";
                    cantpochimons[0, 1] = "Nombre";
                    cantpochimons[0, 2] = "Tipo";
                    cantpochimons[0, 3] = "Nivel";
                    cantpochimons[0, 4] = "Estado";
                    cantpochimons[0, 5] = "ivestigador asignado";
                }
            }







            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("--------------------------------------------------\nMenú Principal - Centro de Investigación de Pochimons\n--------------------------------------------------\n");
                Console.WriteLine("Pochimones Encontrados: " + (contador) + "/75\n");
                Console.WriteLine("1.Registrar Pochimon");
                Console.WriteLine("2. Asignar Investigador a Pochimon");
                Console.WriteLine("3. Actualizar Nivel de Pochimon");
                Console.WriteLine("4. Marcar Pochimon como Investigado");
                Console.WriteLine("5. Mostrar Información de Pochimons");
                Console.WriteLine("6. Buscar Pochimons por Tipo");
                Console.WriteLine("7. Mostrar Pochimons por Investigador");
                Console.WriteLine("8. Mostrar Pochimons Picados");
                Console.WriteLine("9. Salir");
                Console.WriteLine("--------------------------------------------------\nIngrese la opción deseada:");

                int opcion;
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        {
                            for (int i = 0; i < 1; i++)
                            {
                                Console.Write("Ingrese el nombre del Pochimon: ");
                                pochimon = Console.ReadLine();

                            }
                            break;
                        }


                    case 9:

                        Console.WriteLine("Programa Finalizado");
                        continuar = false;


                        break;

                    default:
                        Console.WriteLine("Opción no valida, ingrese una valida");
                        break;



                }
                Console.ReadKey();
            
            }

        }
    }
}
