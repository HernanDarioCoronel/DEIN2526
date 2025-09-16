using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radianes
{
    class Converesor
    {
        public static double ARadianes(double grados)
        {
            return grados * (Math.PI / 180);
        }

        public static double AGrados(double radianes)
        {
            return radianes * (180 / Math.PI);
        }
    }
}
