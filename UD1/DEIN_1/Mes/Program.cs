using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes
{
    /**
     * Hacer un programa que le pida al usuario un número del 1 al 12 y escriba el nombre del mes que 
     * corresponde a ese número. Utilizar un ‘case default’
     * */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un nro e mes:");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Enero");
                    break;
                case "2":
                    Console.WriteLine("Febrero");
                    break;
                case "3":
                    Console.WriteLine("Marzo");
                    break;
                case "4":
                    Console.WriteLine("Abril");
                    break;
                case "5":
                    Console.WriteLine("Mayo");
                    break;
                case "6":
                    Console.WriteLine("Junio");
                    break;
                case "7":
                    Console.WriteLine("Julio");
                    break;
                case "8":
                    Console.WriteLine("Agosto");
                    break;
                case "9":
                    Console.WriteLine("Septiembre");
                    break;
                case "10":
                    Console.WriteLine("Octubre");
                    break;
                case "11":
                    Console.WriteLine("Noviembre");
                    break;
                case "12":
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    Console.WriteLine("Ese mes no existe");
                    break;
            }
        }
        Console.ReadKey();
    }
}
