using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos
{
    class Program
    {
        // 2. Hacer un programa que calcule los números primos que existen entre el 1 y el 100.
        static void Main(string[] args)
        {
            Console.WriteLine("Números primos entre 1 y 100:");

            for (int num = 2; num <= 100; num++)
            {
                bool esPrimo = true;

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    Console.Write(num + " ");
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
