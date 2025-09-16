using System;
using DEIN_1.TomaDeDecisiones;

namespace DEIN_1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Seleccione un ejercicio");

            switch (Console.ReadLine())
            {
                case "1":
                    Mes.GetMes();
                    break;
                case "2":
                    Par.EsPar();
                    break;
                case "3":
                    Estacionamiento.Precio();
                    break;
                case "4":
                    Estacionamiento.Precio();
                    break;
                default:
                    Console.WriteLine("Ese ejercicio nno existe");
                    break;
            }

            Console.ReadKey();
        }
    }
}
