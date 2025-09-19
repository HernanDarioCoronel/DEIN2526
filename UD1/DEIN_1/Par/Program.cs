using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par
{
    class Program
    {
        /**
         * Hacer un programa que le pida al usuario un número y decirle si éste es par o impar.
        * */
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            int num;

            if (int.TryParse(Console.ReadLine(), out num))
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("Es Par.");
                }
                else
                {
                    Console.WriteLine("Es impar");
                }
            }
            else
            {
                Console.WriteLine("Número inválido");
            }
        Console.ReadKey();
        }
    }
}
