using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potencia
{
    class Program
    {
        /**
         * 1. Hacer un programa que calcule la potencia, ya sea positiva o negativa, de cualquier exponente.
         * */
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int num;
            if (int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Ingrese el exponente");
                int exponente;
                if (int.TryParse(Console.ReadLine(), out exponente))
                {
                    if (exponente == 0)
                    {
                        Console.WriteLine(num + " ^ " + exponente + " = 1");
                    }
                    else if (exponente == 1)
                    {
                        Console.WriteLine(num + " ^ " + exponente + " = " + num);
                    }
                    else if (exponente > 1)
                    {
                        int result = num;
                        for (int i = 0; i < exponente; i++)
                        {
                            result *= num;
                        }
                        Console.WriteLine(num + " ^ " + exponente + " = " + result);
                    }
                    else
                    {
                        int divisor = num;
                        for (int i = 0; i < exponente; i++)
                        {
                            divisor *= num;
                        }
                        Console.WriteLine(num + " ^ " + exponente + " = " + "1 / " + divisor + " = " + 1 / divisor);

                    }
                }
                else
                {
                    Console.WriteLine("Número inválido");
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
