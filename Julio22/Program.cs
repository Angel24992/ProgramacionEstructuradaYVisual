using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bucle WHILE

            int num = 0;
            while (num < 10)
            {
                Console.WriteLine(num + " Hola Mundo");
                num++;
            }
            

            // Imprimir con el bucle while en forma acendente y decendente

            Console.WriteLine("Ingrese un número hasta donde desee llegar: ");
            int numIng = int.Parse(Console.ReadLine());

            Console.WriteLine("Números acendentes");
            int numA = 0;
            while (numA <= numIng)
            {
                Console.Write(numA + " ");
                numA++;
            }

            Console.WriteLine(); 
            Console.WriteLine("Números decendente");
            int numD = 0;
            while (numIng >= numD)
            {
                Console.Write(numIng + " ");
                numIng--;
            }
            Console.ReadKey();
        }
    }
}
