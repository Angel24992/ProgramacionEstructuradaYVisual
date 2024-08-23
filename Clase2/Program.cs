using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * TIPOS DE DATOS
             * Tipo Eentero:
             * short, long, byte, int
             * Tipo Flotante:
             * float, double
             * Tipo Cadena:
             * char, string
             * Tipo Bool:
             * true, false
             */

            /*
             * DECLARACIÓN DE VARIABLE
             * Sintaxis:
             * 1. Indicar el tipo de dato
             * 2. Asignar un nombre
             * 3. Utilizar el operador de asignación (=)
             * 4. Asignar un valor
             * 5. Colocar el punto y coma (;)
             */
            /*int num2 = 23;*/

            /*
             * ENTRADA DE DATOS POR TECLADO
             * Utilizar la clase Console y el método .ReadLine(). 
             * Este metodo devuelve como resultado una cadena (string)
             * No recibe ningún argumento
             * 
             * MOSTRAR UN MENSAJE POR PANTALLA
             * Utilizar la clase Console y el método .WriteLine().
             * 
             * PARA IMPRIMIR UNA VARIABLE
             * 1. Utilizar el metodo .WriteLine()
             * 2. Dentro de los parentesis colocar $ y ""
             * 3. Dentro de las "" escribir el mensaje. Se puede concatenar con {}
             * 4. Dentro de las {} escribir la varible
             */

            /*Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Su nombre es {nombre}");*/

            // EJERICIO
            // Declarar 5 variables e imprimir
            // Se solicita al usuario que ingrese varios datos
            /*Console.Write("Ingresa tu nombre: ");
            string name = Console.ReadLine();
            Console.Write("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Ingresa tu altura: ");
            double alt = double.Parse(Console.ReadLine());
            Console.Write("Ingresa tu genero: ");
            string gen = Console.ReadLine();
            Console.Write("Ingresa tu peso: ");
            double peso = double.Parse(Console.ReadLine());
            // Se imprime los datos
            Console.WriteLine($"Te llamas {name}, tiene {edad} años, mides {alt} metros, tu genero es {gen}, y pesas {peso} kg");          
            Console.ReadKey();*/

            /*
             * OPERADORES ARITMÉTICOS
             * +, -, *, /, %
             */

            // EJERCICIO
            // Pedir 2 números al usuario y +, -, *, /, %
            // Se solicita al usuario que ingrese 2 números
            /* Console.Write("Ingrese 1er número: ");
             double num1 = double.Parse(Console.ReadLine());
             Console.Write("Ingrese 2do número: ");
             double num2 = double.Parse(Console.ReadLine());
             // Se realiza la operaciones
             Console.WriteLine($"Suma: {num1} + {num2} = {num1+num2}\n" +
                 $"Resta: {num1} - {num2} = {num1 - num2}\n" +
                 $"Multiplicación: {num1} * {num2} = {num1 * num2}\n" +
                 $"División: {num1} / {num2} = {num1 / num2}\n" +
                 $"Módulo: {num1} % {num2} = {num1 % num2}\n");
             Console.ReadKey();*/

            /*
             * OPERADORES RELACIONALES
             * >, <, ==, !=, >=, <=
             */
            // EJERCICIO
            //  Realiazar los 6 operadores relacionales
            /*bool c1 = 4 > 3;
            bool c2 = 6 < 3;
            bool c3 = 8 == 8;
            bool c4 = 9 >= 3;
            bool c5 = 7 <= 3;
            bool c6 = 3 != 3;
            Console.WriteLine($"4 > 3 = {c1}\n" +
                $"6 < 3 = {c2}\n" +
                $"8 == 8 = {c3}\n" +
                $"9 >= 3 = {c4}\n" +
                $"7 <= 3 = {c5}\n" +
                $"3 != 3 = {c6}\n");
            Console.ReadKey();*/

            /*
             * OPERADORES LÓGICOS
             * && -> Las 2 condiciones deben ser verdaderas
             * || -> Basta que una condición sea verdadera 
             * ! -> Invierte el resultado
             */
            // Ejemplos
            bool lo = true && true; // true
            bool lo1 = 5 > 3 && 3 < 9; // true
            bool lo2 = true && false; // false
            bool lo3 = true || false; // true
            bool lo4 = false || true; // true
            bool lo5 = false || false; // false
            bool lo6 = !false; // true
            bool lo7 = !true; // false

            /*
             * PALABRAS RESERVADAS
             * Son palabras propias del lenguaje que no se pueden utilzar para declarar variables.
             * Ejemplo: if, else, while, for, int
             */

            /*
             * VARIABLES Y CONSTANTES
             * Variable: es un espacio de memoria que asigna el programa para la entrada y salida de datos
             * Constante: son valores que no pueden ser modificados
             */
            // EJERCICIO
            // Invertir el resultado num = 45 y num2 = 85
            int num = 85;
            int num2 = 45;

            int aux = 0;

            aux = num2; // aux 45
            num2 = num; // num2 85
            num = aux;

            Console.WriteLine($"{num}\n" +
                $"{num2}");
            Console.ReadKey();
        }
    }
}
