namespace Fractals.Fraktály
{
    internal class Julia
    {
        private static int x0, y0;
        private static double x, y;

        public static Bitmap NakresliJulia(int sirka, int vyska, int iterace, Color barva, Color barvaPozadi, int priblizeni,
            double cRe, double cIm, double offsetX, double offsetY)
        {
            // deklarace, inicializace
            Bitmap bm = new Bitmap(sirka, vyska);
            Color tempBarva;

            for (x0 = 0; x0 < sirka; x0++)
            {
                for (y0 = 0; y0 < vyska; y0++)
                {
                    x = (x0 - sirka / 2) / (0.5 * priblizeni * sirka) + offsetX;
                    y = (y0 - vyska / 2) / (0.5 * priblizeni * vyska) + offsetY;

                    int i;

                    for (i = 0; i < iterace; i++)
                    {
                        double tempX = x;
                        double tempY = y;
                        x = (tempX * tempX) - (tempY * tempY) + cRe;
                        y = 2 * tempX * tempY + cIm;
                        if ((x * x + y * y) > 4) break;
                    }

                    tempBarva = i < iterace ? barvaPozadi : barva;

                    bm.SetPixel(x0, y0, tempBarva);
                }
            }

            return bm;
        }
    }
}
