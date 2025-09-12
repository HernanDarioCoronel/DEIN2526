using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraAppDeConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                Console.WriteLine("Ingrese el primer número");
                if (!Int32.TryParse(Console.ReadLine(), out num1))
                    throw new Exception("eso no es un numero!");

                Console.WriteLine("Ingrese el segundo número");
                if (!Int32.TryParse(Console.ReadLine(), out num2))
                    throw new Exception("eso no es un numero!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error.\n {0}", ex.Message);
            }

            if(num1 > 30 || num2 > 30)
            {
                Console.WriteLine("Un ´número es mayor a 30!!");
            }else if (num1 + num2 >= 30)
            {
                Console.WriteLine("La suma es mayor a 30!!!");
            }
            else
            {
                Console.WriteLine("ningun numero ni la suma son mayor a 30 :(");
            }
            Console.WriteLine("Presione enter para salir.....");
            Console.ReadKey();
        }
    }
}
