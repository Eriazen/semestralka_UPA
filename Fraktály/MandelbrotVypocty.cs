using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Fractals.Fraktály
{
    internal class MandelbrotVypocty
    {
        private double x, y;

        public MandelbrotVypocty(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Mocnina()
        {
            double temp = x * x - y * y;
            y = 2 * x * y;
            x = temp;
        }

        public double Magnituda()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public void Pridej(MandelbrotVypocty c)
        {
            x += c.x;
            y += c.y;
        }
    }
}
