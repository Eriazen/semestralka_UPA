namespace Fractals.Fraktály
{
    internal class Julia
    {
        private static int x0, y0;
        private static double x, y;

        public static Bitmap NakresliJulia(int sirka, int vyska, int iterace, Color barva, int priblizeni,
            double offsetX, double offsetY)
        {
            // deklarace, inicializace
            Bitmap bm = new Bitmap(sirka, vyska);
            Color tempBarva;

            for (x0 = 0; x0 < sirka; x0++)
            {
                for (y0 = 0; y0 < vyska; y0++)
                {
                    x = (((double)(x0 - (sirka / 2)) / (sirka / 4)) / priblizeni) + offsetX;
                    y = (((double)(y0 - (vyska / 2)) / (vyska / 4)) / priblizeni) + offsetY;

                    MandelbrotVypocty l = new MandelbrotVypocty(0.5, 0.5);
                    MandelbrotVypocty z = new MandelbrotVypocty(0, 0);

                    int i = 0;

                    do
                    {
                        i++;
                        z.Julia(l);
                        if (z.Magnituda() > 2) break;
                    } while (i < iterace);

                    if (i < iterace) tempBarva = Color.WhiteSmoke;
                    else tempBarva = barva;

                    bm.SetPixel(x0, y0, tempBarva);
                }
            }

            return bm;
        }
    }
}
