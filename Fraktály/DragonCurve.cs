namespace Fractals.Fraktály
{
    internal class DragonCurve
    { // rekurzivni metoda pro kresleni Dragon Curve fraktalu
        public static Graphics DrawDragonLine(Graphics gr, int iterace,
            Direction otocit, float sirka, float vyska, float dx, float dy, Pen pen)
        {
            if (iterace <= 0)
            {
                gr.DrawLine(pen, sirka, vyska, sirka + dx, vyska + dy);
            }
            else
            {
                float nx = (float)(dx / 2);
                float ny = (float)(dy / 2);
                float dx2 = -ny + nx;
                float dy2 = nx + ny;
                if (otocit == Direction.Right)
                {
                    // Otoc vpravo
                    DrawDragonLine(gr, iterace - 1, Direction.Right,
                        sirka, vyska, dx2, dy2, pen);
                    float x2 = sirka + dx2;
                    float y2 = vyska + dy2;
                    DrawDragonLine(gr, iterace - 1, Direction.Left,
                        x2, y2, dy2, -dx2, pen);
                }
                else
                {
                    // Otoc vlevo
                    DrawDragonLine(gr, iterace - 1, Direction.Right,
                        sirka, vyska, dy2, -dx2, pen);
                    float x2 = sirka + dy2;
                    float y2 = vyska - dx2;
                    DrawDragonLine(gr, iterace - 1, Direction.Left,
                        x2, y2, dx2, dy2, pen);
                }
            }
            return gr;
        }
    }

    // enum ktery udava uhel otoceni
    internal enum Direction
    {
        Left,
        Right,
    }
}
