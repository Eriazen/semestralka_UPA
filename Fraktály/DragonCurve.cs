namespace Fractals.Fraktály
{
    internal class DragonCurve
    { // rekurzivni metoda pro kresleni Dragon Curve fraktalu, (WIP --- pravdepodobne prevedu na objekt)
        public static Graphics DrawDragonLine(Graphics gr, int iterace,
            Direction otocit, float x1, float y1, float dx, float dy, Pen pen)
        {
            if (iterace <= 0)
            {
                gr.DrawLine(pen, x1, y1, x1 + dx, y1 + dy);
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
                        x1, y1, dx2, dy2, pen);
                    float x2 = x1 + dx2;
                    float y2 = y1 + dy2;
                    DrawDragonLine(gr, iterace - 1, Direction.Left,
                        x2, y2, dy2, -dx2, pen);
                }
                else
                {
                    // Otoc vlevo
                    DrawDragonLine(gr, iterace - 1, Direction.Right,
                        x1, y1, dy2, -dx2, pen);
                    float x2 = x1 + dy2;
                    float y2 = y1 - dx2;
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
