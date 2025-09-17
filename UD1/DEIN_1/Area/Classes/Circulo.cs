using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Circulo
    {
        public static double CalcularArea(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
