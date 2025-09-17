using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radianes
{
    class Converesor
    {
        public static void ARadianes(double grados, ref double resultado)
        {
            resultado = grados * (Math.PI / 180);
        }

        public static void AGrados(double radianes, ref double resultado)
        {
            resultado = radianes * (180 / Math.PI);
        }
    }
}
