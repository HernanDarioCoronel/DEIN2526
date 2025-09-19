using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros misNumeros = new Numeros();
            bool salir = false; ;

            while (!salir)
            {
                Console.WriteLine("Ingrese un nro.");
                int nro;
                if (!int.TryParse(Console.ReadLine(), out nro))
                {
                    Console.WriteLine("Eso no es un nro.");
                }
                else
                {
                    if (misNumeros.Exists(nro))
                    {
                        Console.WriteLine("Ya existe");
                    }
                    else
                    {
                        misNumeros += nro;
                    }
                    Console.WriteLine("Desea continuar? (s/n)");
                    switch (Console.ReadLine())
                    {
                        case "N":
                        case "n":
                            salir = true;
                            break;
                        default:
                            break;
                    }
                }
            }

            Console.WriteLine(misNumeros);

            Console.ReadKey();
        }
    }
}
