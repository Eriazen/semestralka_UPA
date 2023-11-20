namespace Fractals.Fraktály
{
    internal class MandelbrotVypocty
    {
        // deklarace
        private double x, y;

        // konstruktor
        public MandelbrotVypocty(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // umocni
        public void Mocnina()
        {
            double temp = x * x - y * y;
            y = 2 * x * y;
            x = temp;
        }

        // zjisti velikost
        public double Magnituda()
        {
            return Math.Sqrt(x * x + y * y);
        }

        // prida hodnotu
        public void Pridej(MandelbrotVypocty c)
        {
            x += c.x;
            y += c.y;
        }
    }
}
