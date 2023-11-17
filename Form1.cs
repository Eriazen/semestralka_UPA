using Fractals.Fraktály;

namespace Fractals
{
    public partial class Form1 : Form
    {
        // deklarace/inicializace
        private Bitmap bm;
        private Pen pen = Pens.Red;
        private Graphics gr;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { // nakresli fraktal po spusteni
            bm = new Bitmap(panel1.Width, panel1.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            gr = Graphics.FromImage(bm);

            float x = panel1.Width / 3;
            float y = panel1.Height / 4;
            float fx = panel1.Width / 2;
            float fy = panel1.Height / 3;
            int iterations = (int)numericUpDown1.Value;

            gr = DragonCurve.DrawDragonLine(gr, iterations, Direction.Right, x, y, fx, fy, pen);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // musim odstranit
        }

        private void button1_Click(object sender, EventArgs e)
        { // zmena hodnot a render po kliknuti
            bm = new Bitmap(panel1.Width, panel1.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            gr = Graphics.FromImage(bm);

            float x = panel1.Width / 3;
            float y = panel1.Height / 4;
            float fx = panel1.Width / 2;
            float fy = panel1.Height / 3;
            int iterations = (int)numericUpDown1.Value;

            gr = DragonCurve.DrawDragonLine(gr, iterations, Direction.Right, x, y, fx, fy, pen);

            // donuti program znovu vykreslit fraktal
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        { // kresli fraktal
            e.Graphics.DrawImage(bm, 0, 0, bm.Width, bm.Height);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // musim odstranit
        }

        private void button2_Click(object sender, EventArgs e)
        { // WIP - zmeny barvu dle vyberu
            Pen pen = new Pen(Color.Red);
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                pen.Color = cd.Color;
            }
        }
    }
}