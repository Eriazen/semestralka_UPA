using Fractals.Fraktály;

namespace Fractals
{
    public partial class Form1 : Form
    {
        // deklarace/inicializace
        private Bitmap bm;
        private Pen pen = new Pen(Color.Red);
        private Graphics gr;
        private Color barva = Color.Black;

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

            gr = DragonCurve.DrawDragonLine(gr, 10, Direction.Right, panel1.Width / 3,
                panel1.Height / 4, panel1.Width / 2, panel1.Height / 3, pen);
        }

        private void button1_Click(object sender, EventArgs e)
        { // zmena hodnot a render po kliknuti

            // inicializace
            int iterace = (int)numericUpDown1.Value;
            int priblizeni = (int)numericUpDown2.Value;
            double hScroll = (double)hScrollBar1.Value / 1000;
            double vScroll = (double)vScrollBar1.Value / 1000;

            // WIP ---- vykresli fraktal dle vyberu
            switch (comboBox1.SelectedIndex)
            {
                case 0: // dragon curve
                    bm = new Bitmap(panel1.Width, panel1.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                    gr = Graphics.FromImage(bm);

                    gr = DragonCurve.DrawDragonLine(gr, iterace, Direction.Right, panel1.Width / 3,
                        panel1.Height / 4, panel1.Width / 2, panel1.Height / 3, pen);
                    break;
                case 1: //mandelbrot
                    bm = Mandelbrot.NakresliMandelbrot(panel1.Width, panel1.Height, iterace, barva, priblizeni, hScroll, vScroll);
                    break;
                case 2: // julia
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
                barva = cd.Color;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    numericUpDown1.Maximum = 20;
                    numericUpDown1.Value = 10;
                    break;
                case 1:
                    numericUpDown1.Maximum = 100;
                    numericUpDown1.Value = 50;
                    break;
                case 2:
                    break;
            }
        }

        // otevre savefile dialog
        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bm.Save(saveFileDialog1.FileName);
        }

        // otevre openfile dialog
        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bm = new Bitmap(openFileDialog1.FileName);
            panel1.Invalidate();
        }
    }
}