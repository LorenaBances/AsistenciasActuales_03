using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciasActuales_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int maxPersonas = 50;
            int contador = 3;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("| Asistentes actuales | " + contador);
                Console.WriteLine("| Aforo | " + ((double)contador / maxPersonas * 100).ToString("0.0") + "%");
                Console.WriteLine("| Máximo | " + maxPersonas + " personas");
                Console.WriteLine("=================================");
                Console.WriteLine("Presione");
                Console.WriteLine("[ i ] si ingresa una persona");
                Console.WriteLine("[ s ] si sale una persona");
                Console.WriteLine("[ x ] para terminar");
                Console.Write("_");

                string opcion = Console.ReadLine().ToLower();

                switch (opcion)
                {
                    case "i":
                        if (contador < maxPersonas)
                        {
                            contador++;
                        }
                        else
                        {
                            Console.WriteLine("Se ha alcanzado el número máximo de personas: ");
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;

                    case "s":
                        if (contador > 0)
                        {
                            contador--;
                            Console.WriteLine("Se retira una persona");
                        }
                        else
                        {
                            Console.WriteLine("No hay personas para retirar: ");
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;

                    case "x":
                        Console.WriteLine("Terminando el programa...");
                        return;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingrese una opción válida (i, s o x): ");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
            
        }
    }
}
