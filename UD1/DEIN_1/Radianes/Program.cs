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
            double resultado = 0;
            double num;
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Ingrese un número");
                    if (double.TryParse(Console.ReadLine(), out num))
                    {
                        Converesor.ARadianes(num, ref resultado);
                        Console.WriteLine("Resultado: " + resultado + "Radianes");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido");
                    }
                    break;
                case "2":
                    Console.WriteLine("Ingrese un número");
                    if (double.TryParse(Console.ReadLine(), out num))
                    {
                        Converesor.AGrados(num, ref resultado);
                        Console.WriteLine("Resultado: " + resultado + "°");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido");
                    }
                    break;
                default:
                    Console.WriteLine("La opción no existe.");
                    break;

            }

            Console.ReadKey();
        }
    }
}
