using System.Security.Cryptography.X509Certificates;
using Fractals.Fraktály;

namespace Fractals
{
    public partial class Form1 : Form
    {
        private Bitmap bm;
        private Pen pen;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics gr;
            bm = new Bitmap(panel1.Width, panel1.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            gr = Graphics.FromImage(bm);

            Pen pen = Pens.Red;
            float x = panel1.Width / 3;
            float y = panel1.Height / 4;
            float fx = panel1.Width / 2;
            float fy = panel1.Height / 3;
            int iterations = (int)numericUpDown1.Value;

            gr = DragonCurve.DrawDragonLine(gr, iterations, Direction.Right, x, y, fx, fy, pen);
            gr.Dispose();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;

            gr.DrawImage(bm, 0, 0, bm.Width, bm.Height);
            gr.Dispose();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                pen.Color = cd.Color;
            }
            cd.Dispose();
        }
    }
}