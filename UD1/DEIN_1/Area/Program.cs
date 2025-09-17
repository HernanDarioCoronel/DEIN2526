using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Area;

namespace Area
{
    class Program
    {
        // 2. Crea una aplicación que calcule el área de un círculo, cuadrado o triángulo. Le preguntaremos al 
        // usuario a qué figura le quiere calcular el área y dependiendo el caso, ejecutará uno de los 3 métodos
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Seleccione una opción:");
            sb.AppendLine("\t1) Area de un círculo.");
            sb.AppendLine("\t2) Area de un cuadrado.");
            sb.AppendLine("\t3) Area de un triángulo.");

            switch (Console.Read())
            {
                case 1:
                    Console.WriteLine("Ingrese el radio del cículo");
                    double value;
                    if (double.TryParse(Console.ReadLine(), out value))
                    {

                    }
                    else
                    {
                        Console.WriteLine("");
                    }
            }
        }
    }
}
