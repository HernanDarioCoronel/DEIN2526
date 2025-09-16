using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radianes
{
    class Program
    {
        // 1. Crea un método para transformar de grados a radianes, utiliza paso de parámetros por referencia.

        static void Main(string[] args)
        {
            Console.WriteLine("1\t grados a radianes");
            Console.WriteLine("2\t radianes a grados");
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Ingrese un número");
                double num;

                if (double.TryParse(Console.ReadLine(), out num))
                {
                    double result = Converesor.ARadianes(num);
                    Console.WriteLine("Resultado: " + result + "Radianes");
                }
                else
                {
                    Console.WriteLine("Número inválido");
                }
            }
            else if (Console.ReadLine() == "2")
            {
                Console.WriteLine("Ingrese un número");
                double num;

                if (double.TryParse(Console.ReadLine(), out num))
                {
                    double result = Converesor.AGrados(num);
                    Console.WriteLine("Resultado: " + result + "°");
                }
                else
                {
                    Console.WriteLine("Número inválido");
                }
            }
            else
            {
                Console.WriteLine("La opción no existe.");
            }
            Console.ReadKey();
        }
    }
}
