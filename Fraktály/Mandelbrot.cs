namespace Fractals.Fraktály
{
    internal class Mandelbrot
    {
        // deklarace
        private static int x0, y0;
        private static double x, y;

        public static Bitmap NakresliMandelbrot(int sirka, int vyska, int iterace, Color barva, Color barvaPozadi, int priblizeni, double offsetX, double offsetY)
        {
            // deklarace, inicializace
            Bitmap bm = new Bitmap(sirka, vyska);
            Color tempBarva;

            // hlavni loop
            for (x0 = 0; x0 < sirka; x0++)
            {
                for (y0 = 0; y0 < vyska; y0++)
                {
                    // prirazeni hodnot promennym x a y
                    x = (x0 - sirka / 2) / (0.5 * priblizeni * sirka) + offsetX;
                    y = (y0 - vyska / 2) / (0.5 * priblizeni * vyska) + offsetY;

                    // inicializace komplexu
                    MandelbrotVypocty c = new MandelbrotVypocty(x, y);
                    MandelbrotVypocty z = new MandelbrotVypocty(0, 0);

                    // inicializace pomocne promenne i
                    int i = 0;

                    // loop pro urceni poctu iteraci
                    do
                    {
                        i++;
                        z.Mocnina();
                        z.Pridej(c);
                        if (z.Magnituda() > 2) break;
                    } while (i < iterace);

                    // pokud vypocet "vybouchne", tak obarvi pixel na bilo, jinak na zvolenou barvu
                    tempBarva = i < iterace ? barvaPozadi : barva;

                    bm.SetPixel(x0, y0, tempBarva);
                }
            }

            return bm;
        }
    }
}
