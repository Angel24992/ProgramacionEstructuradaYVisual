using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionEstructuradaYVisual
{ // Llave de inicio de solución: encapsula la clase para evitar conflictos con los demás proyectos
    internal class Program
    {
        static void Main(string[] args)
        {

            // TIPOS DE DATOS

            // Tipo Entero
            /*
             * Pasos para declarar una variable:
             * 1. Indico el tipo de dato
             * 2. Le asigno un nombre
             * 3. Utilizo el operador de asignación
             * 4. Indico el valor
             * 
             * Forma para imprimir en la consola:
             * Utilizar la clase Console y utilizar el metodo .WriteLine
             * 
             * Forma para que la consola se cierre cuando el usuario aplaste una tecla
             * Utilizar la clase Console y utilizar el metodo .ReadKey();
             */

            int num = 4;
            Console.WriteLine(num);
            Console.WriteLine("El número ingresado es " + num);
            Console.WriteLine($"El número ingresado es {num}");
            //Console.ReadKey();

            // Variable byte solo se almacena valores de 0 a 255
            byte num1 = 233;
            //Console.WriteLine(num1);
            short num2 = 45;
            long num3 = 67;


            // Tipo Flotante
            float num4 = 1.0f;
            double num5 = 12.36;

            // Tipo Cadena
            char letra = 'a';
            string nombre = "Angel";

            // Tipo Bool
            bool verdad = true;
            bool falso = false;

            // OPERADORES

            // Operadores Aritméticos

            // +, -, *, /, %

            // Operadores lógicos

            // &&, ||, !

            // Operadores de Incrimento (++, --)

            /*
             * Forma para la entrada de datos por teclado
             * Clase Console metodo .ReadLine();
             */

            // Ejercicio: Solicitar al usuario que ingrese su nombre y edad. Imprimir en la consola
            Console.WriteLine("Escriba su nombre");
            string nombre1 = Console.ReadLine();
            Console.WriteLine("Escriba su edad");
            string edad = Console.ReadLine();
            Console.WriteLine($"Su nombre es {nombre1} y tienes {edad} años"); 
            //Console.ReadKey();

            // Ejercicio: Solicitar al usuario que ingrese 2 números y realizar las operaciones aritméticas
            Console.Write("Ingrese 1er número: ");
            int num6 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese 2do número: ");
            int num7 = int.Parse(Console.ReadLine());
            Console.WriteLine($"La suma de {num6} + {num7} = {num6 + num7}");
            Console.WriteLine($"La resta de {num6} - {num7} = {num6 - num7}");
            Console.WriteLine($"La multiplicación de {num6} * {num7} = {num6 * num7}");
            Console.WriteLine($"La división de {num6} / {num7} = {(double)num6 / num7}");
            Console.WriteLine($"El módulo de {num6} % {num7} = {num6 % num7}");
            Console.ReadKey();
        }
    }
}
