using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sentencia SWITCH

            // Recibe un argumento un valor y lo evalúa en casos

            // Pedir un día de la semana al usuario e imprimir cuantas letras tiene el día

            // Muestra mensaje al usuario en la consola
            Console.WriteLine("Ingrese un día de la semana");
            // Solicita que ingrese un día al usuario
            string dia = Console.ReadLine();

            // Iniciamos la sentencia switch, y usamos el método ToLower para convertir el texto ingresado en minusculas
            switch(dia.ToLower())
            {
                case "lunes":
                    Console.WriteLine($"El día {dia} tiene {dia.Length} letras");
                    break;
                case "martes":
                    Console.WriteLine($"El día {dia} tiene {dia.Length} letras");
                    break;
                case "miercoles":
                    Console.WriteLine($"El día {dia} tiene {dia.Length} letras");
                    break;
                case "jueves":
                    Console.WriteLine($"El día {dia} tiene {dia.Length} letras");
                    break;
                case "viernes":
                    Console.WriteLine($"El día {dia} tiene {dia.Length} letras");
                    break;
                case "sabado":
                    Console.WriteLine($"El día {dia} tiene {dia.Length} letras");
                    break;
                case "domingo":
                    Console.WriteLine($"El día {dia} tiene {dia.Length} letras");
                    break;
                default:
                    Console.WriteLine($"{dia} valor ingresado no valido");
                    break;
            }
            // Console.ReadKey();

            // Bucle FOR

            Console.WriteLine("Ingrese un número: ");
            int num = int.Parse( Console.ReadLine() );

            for ( int i = 0; i <= num; i++ )
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    break;
                }
            }
            // Console.ReadKey();

            // Imprimir los números pares

            Console.WriteLine($"Los números pares del 1 a {num} son: ");
            for ( int i = 1; i <= num;i++ )
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

            // Imprimir los números impares

            Console.WriteLine($"Los números impares del 1 a {num} son: ");
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                    if(i == 49)
                    {
                        break ;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
