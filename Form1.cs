using Fractals.Fraktály;

namespace Fractals
{
    public partial class Form1 : Form
    {
        // deklarace/inicializace
        private Bitmap bm;
        private Pen pen = new Pen(Color.Red);
        private Graphics gr;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // vybere dragon curve jako zakladni hodnotu
            comboBox1.SelectedIndex = 0;

            // vykresli dragoncurve fraktal po spusteni
            bm = new Bitmap(panel1.Width, panel1.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            gr = Graphics.FromImage(bm);

            float x = panel1.Width / 3;
            float y = panel1.Height / 4;
            float fx = panel1.Width / 2;
            float fy = panel1.Height / 3;
            int iterations = (int)numericUpDown1.Value;

            gr = DragonCurve.DrawDragonLine(gr, iterations, Direction.Right, x, y, fx, fy, pen);
        }

        private void button1_Click(object sender, EventArgs e)
        { // zmena hodnot a render po kliknuti

            float x = panel1.Width / 3;
            float y = panel1.Height / 4;
            float fx = panel1.Width / 2;
            float fy = panel1.Height / 3;
            var iterace = (int)numericUpDown1.Value;

            // WIP ---- vykresli fraktal dle vyberu
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    bm = new Bitmap(panel1.Width, panel1.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                    gr = Graphics.FromImage(bm);
                    gr = DragonCurve.DrawDragonLine(gr, iterace, Direction.Right, x, y, fx, fy, pen);
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }

            // donuti program znovu vykreslit fraktal
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        { // kresli fraktal
            e.Graphics.DrawImage(bm, 0, 0, bm.Width, bm.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        { // zmena barvy dle vyberu
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                pen.Color = cd.Color;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}