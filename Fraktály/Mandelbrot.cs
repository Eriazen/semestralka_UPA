using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fractals.Fraktály
{
    internal class Mandelbrot
    {
        private static int x0, y0;
        private static double x, y;

        public static Bitmap NakresliMandelbrot(int sirka, int vyska, int iterace, Color barva)
        {
            Bitmap bm = new Bitmap(sirka, vyska);
            Color tempBarva;

            for (x0 = 0; x0 < sirka; x0++)
            {
                for (y0 = 0; y0 < vyska; y0++)
                {
                    // prirazeni hodnot promennym x a y
                    x = (double)(x0 - (sirka / 2)) / (double)(sirka / 4);
                    y = (double)(y0 - (vyska / 2)) / (double)(sirka / 4);

                    // inicializace komplexu
                    MandelbrotVypocty c = new MandelbrotVypocty(x, y);
                    MandelbrotVypocty z = new MandelbrotVypocty(0, 0);

                    // inicializace pomocne promenne i
                    int i = 0;

                    do
                    {
                        i++;
                        z.Mocnina();
                        z.Pridej(c);
                        if (z.Magnituda() > 2) break;
                    } while (i < iterace);

                    if (i < iterace) tempBarva = Color.Black;
                    else tempBarva = barva;

                    bm.SetPixel(x0, y0, tempBarva);
                }
            }

            return bm;
        }
    }
}
