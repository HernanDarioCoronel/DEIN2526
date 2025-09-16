using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEIN_1.TomaDeDecisiones
{
    class Estacionamiento
    {
        /**
         * Hacer un programa que le diga al usuario el precio que debe pagar por el servicio de 
         * estacionamiento de un centro comercial con base en el tiempo que ha permanecido ahí: primeros 60
         * minutos 5€, las primeras 2 horas 15€ y de 2 horas en adelante: 40€
         * */
         public static void Precio()
        {
            Console.WriteLine("Ingrese el tiempo que paso aparcado");
            int tiempo;
            if(int.TryParse(Console.ReadLine(), out tiempo))
            {
                if(tiempo <= 60)
                {
                    Console.WriteLine("5€");
                } else if (tiempo <= 120)
                {
                    Console.WriteLine("15€");
                }
                else
                {
                    Console.WriteLine("40€");
                }
            }
            else
            {
                Console.WriteLine("Número inválido");
            }
        }
    }
}
