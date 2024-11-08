using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_IbarraMedrano_Pochidex
{
    class Program
    {
        static void Main(string[] args)
        {


            string Pochimon;
            string tipo;
            int nivel;
            int estado = 0;
            int investigador = 0;
            int contadorPochi = 0;

            object[,] cantidadPochimons = new object[76, 6];

            for (int i = 0; i < 76; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    cantidadPochimons[0, 0] = "Fila";
                    cantidadPochimons[0, 1] = "Nombre";
                    cantidadPochimons[0, 2] = "Tipo";
                    cantidadPochimons[0, 3] = "Nivel";
                    cantidadPochimons[0, 4] = "Estado";
                    cantidadPochimons[0, 5] = "ivestigador asignado";
                }
            }

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("--------------------------------------------------\nMenú Principal - Centro de Investigación de Pochimons\n--------------------------------------------------\n");
                Console.WriteLine("Pochimones Encontrados: " + (contadorPochi) + "/75\n");
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
                                Pochimon = Console.ReadLine();
                                Console.Write("\n");

                                Console.Write("Ingrese el tipo(A/F/P): ");
                                tipo = Console.ReadLine();
                                Console.Write("\n");

                                Console.Write("Ingrese el nivel: ");
                                nivel = int.Parse(Console.ReadLine());

                                Console.Write("\n");

                                // Guardamos la información en la matriz
                                cantidadPochimons[contadorPochi + 1, 0] = contadorPochi + 1;
                                cantidadPochimons[contadorPochi + 1, 1] = Pochimon;
                                cantidadPochimons[contadorPochi + 1, 2] = tipo;
                                cantidadPochimons[contadorPochi + 1, 3] = nivel;
                                cantidadPochimons[contadorPochi + 1, 4] = 0;
                                cantidadPochimons[contadorPochi + 1, 5] = 0;

                                contadorPochi++;

                                Console.Clear();
                            }
                        }
                        break;


                    case 2:
                        // Mostrar Pochimons no investigados (Estado 0) y sin investigador asignado (Investigador null o 0)
                        Console.WriteLine("Lista de Pochimons no investigados: \n ");
                        Console.WriteLine("Fila\tNombre\tTipo\tNivel");

                        for (int i = 1; i <= contadorPochi; i++)
                        {
                            if (cantidadPochimons[i, 4].ToString() == "0")
                            {
                                Console.Write("\n" + (cantidadPochimons[i, 0]));
                                Console.Write("\t" + (cantidadPochimons[i, 1]));
                                Console.Write("\t" + (cantidadPochimons[i, 2]));
                                Console.Write("\t" + (cantidadPochimons[i, 3]) + "\t");
                            }
                        }

                        Console.WriteLine("\nIngrese el número de fila del Pochimon a asignar: ");
                        int filaSeleccionada = int.Parse(Console.ReadLine());

                        if (filaSeleccionada >= 1 && filaSeleccionada <= contadorPochi &&
                            cantidadPochimons[filaSeleccionada, 4].ToString() == "0" && (cantidadPochimons[filaSeleccionada, 5].ToString() == "0"))
                        {
                            Console.WriteLine("Ingrese el codigo del investigador: ");
                            investigador = int.Parse(Console.ReadLine());

                            // Asignar el investigador y cambiar el estado del Pochimon
                            cantidadPochimons[filaSeleccionada, 5] = investigador;
                            cantidadPochimons[filaSeleccionada, 4] = 1; // Estado: En Investigación
                            Console.WriteLine("Investigador asignado correctamente y estado actualizado.");
                        }
                        else
                        {
                            Console.WriteLine("Número de fila inválido o el Pochimon ya está investigado o tiene un investigador asignado.");
                        }
                        Console.Clear();
                        break;

                    case 3:
                        // Actualizar el nivel de un Pochimon
                        Console.WriteLine("Fila\tNombre\tNivel");
                        for (int i = 1; i <= contadorPochi; i++)
                        {
                            Console.Write("\n" + (cantidadPochimons[i, 0]));
                            Console.Write("\t" + (cantidadPochimons[i, 1]));
                            Console.Write("\t" + (cantidadPochimons[i, 3]) + "\n");

                        }
                        Console.Write("Ingrese el número de fila del Pochimon: ");
                        int filaSeleccionada2 = int.Parse(Console.ReadLine());

                        if (filaSeleccionada2 >= 1 && filaSeleccionada2 <= contadorPochi)
                        {
                            Random rand = new Random();
                            int numRandom = rand.Next(1, 4);

                            int nivelActual = Convert.ToInt32(cantidadPochimons[filaSeleccionada2, 3]);
                            cantidadPochimons[filaSeleccionada2, 3] = nivelActual + numRandom;

                            Console.WriteLine("Nivel actualizado correctamente. El nivel ha aumentado en " + numRandom);
                        }
                        else
                        {
                            Console.WriteLine("Número de fila inválido.");
                        }
                        break;

                    case 4:
                        // Marcar un Pochimon como Investigado
                        Console.WriteLine("Lista de Pochimons no investigados: \n ");
                        Console.WriteLine("Fila\tNombre\tTipo\tNivel\tEstado\tInvestigador");

                        for (int i = 1; i <= contadorPochi; i++)
                        {
                            if (cantidadPochimons[i, 4].ToString() == "1")
                            {
                                Console.Write("\n" + (cantidadPochimons[i, 0]));
                                Console.Write("\t" + (cantidadPochimons[i, 1]));
                                Console.Write("\t" + (cantidadPochimons[i, 2]));
                                Console.Write("\t" + (cantidadPochimons[i, 3]));
                                Console.Write("\t" + (cantidadPochimons[i, 4]));
                                Console.Write("\t" + (cantidadPochimons[i, 5]) + "\n");
                            }
                        }

                        Console.WriteLine("\nIngrese el número de fila del Pochimon a asignar: ");
                        int filaSeleccionada3 = int.Parse(Console.ReadLine());

                        if (filaSeleccionada3 >= 1 && filaSeleccionada3 <= contadorPochi)
                        {
                            cantidadPochimons[filaSeleccionada3, 4] = 2;
                            Console.WriteLine("Pochimon marcado como Investigado.");
                        }
                        else
                        {
                            Console.WriteLine("Número de fila inválido.");
                        }
                        break;

                    case 5:
                        // Mostrar información de todos los Pochimons
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("Información de Pochimons:");
                        Console.WriteLine("Fila\tNombre\tTipo\tNivel\tEstado\tInvestigador");
                        for (int i = 1; i <= contadorPochi; i++)
                        {
                            Console.WriteLine("{cantidadPochimons[i, 0]}\t{cantidadPochimons[i, 1]}\t{cantidadPochimons[i, 2]}\t{cantidadPochimons[i, 3]}\t{cantidadPochimons[i, 4]}\t{cantidadPochimons[i, 5]}");
                        }
                        Console.WriteLine("--------------------------------------------------");
                        break;
                    case 6:
                        Console.WriteLine("Ingrese el tipo de Pochimon a buscar (A/F/P):");
                        string filaSeleccionada4 = Console.ReadLine();
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("ENCONTRAR POCHIMOS CON EL TIPO:" + filaSeleccionada4);
                        Console.WriteLine("Fila\tNombre\tTipo");

                        for (int i = 1; i <= contadorPochi; i++)

                        {
                            if (cantidadPochimons[i, 2].ToString() == filaSeleccionada4)
                            {
                                Console.Write("\n" + cantidadPochimons[i, 0]);
                                Console.Write("\t" + cantidadPochimons[i, 1]);
                                Console.Write("\t" + cantidadPochimons[i, 2] + "\n");
                            }

                        }

                        break;
                    case 7:
                        Console.WriteLine("Ingrese el numero de investigador:");
                        int filaSeleccionada5 = int.Parse(Console.ReadLine());
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("ENCONTRAR POCHIMOS POR EL INVESTIGADOR:" + filaSeleccionada5);
                        Console.WriteLine("Fila\tNombre\tTipo\tNivel\tEstado\tInvestigador Asignado");

                        for (int i = 1; i <= contadorPochi; i++)

                        {
                            if ((Convert.ToInt32 (cantidadPochimons[i, 5]) == filaSeleccionada5))
                            {
                                Console.Write("\n" + cantidadPochimons[i, 0]);
                                Console.Write("\t" + cantidadPochimons[i, 1]);
                                Console.Write("\t" + cantidadPochimons[i, 2] );
                                Console.Write("\t" + cantidadPochimons[i, 3] );
                                Console.Write("\t" + cantidadPochimons[i, 4] );
                                Console.Write("\t" + cantidadPochimons[i, 5] + "\n");
                            }
                            
                        }

                        break;
                    case 8:

     
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("POCHIMOS CON NIVEL MAYOR A 30");
                        Console.WriteLine("Fila\tNombre\tTipo\tNivel\tEstado\tInvestigador Asignado");

                        for (int i = 1; i <= contadorPochi; i++)

                        {
                            if ((Convert.ToInt32(cantidadPochimons[i, 3]) >=30))
                            {
                                Console.Write("\n" + cantidadPochimons[i, 0]);
                                Console.Write("\t" + cantidadPochimons[i, 1]);
                                Console.Write("\t" + cantidadPochimons[i, 2]);
                                Console.Write("\t" + cantidadPochimons[i, 3]);
                                Console.Write("\t" + cantidadPochimons[i, 4]);
                                Console.Write("\t" + cantidadPochimons[i, 5] + "\n");
                            }

                        }

                        break;

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

  
    

