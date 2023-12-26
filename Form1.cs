using Fractals.Fraktály;

namespace Fractals
{
    public partial class Form1 : Form
    {
        // deklarace/inicializace
        private Bitmap bm;
        private Pen pen = new Pen(Color.Black);
        private Graphics gr;
        private Color barva = Color.Black;
        private Color barvaPozadi = Color.WhiteSmoke;
        private int iterace, priblizeni;
        private double hScroll, vScroll, cRe, cIm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // vybere dragon curve jako zakladni hodnotu
            comboBox1.SelectedIndex = 0;
            iterace = 10;
            button5.BackColor = barva;

            // zde musi uzivatel nastavit slozku pro ukladani obrazku
            saveFileDialog1.InitialDirectory = "C:\\Users\\vitve\\Documents\\Škola\\VŠCHT\\UPA\\Fractals\\Ulozene";
            openFileDialog1.InitialDirectory = saveFileDialog1.InitialDirectory;

            // vykresli dragoncurve fraktal po spusteni
            bm = new Bitmap(panel1.Width, panel1.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            gr = Graphics.FromImage(bm);

            gr = DragonCurve.DrawDragonLine(gr, 10, Direction.Right, panel1.Width / 3,
                panel1.Height / 4, panel1.Width / 2, panel1.Height / 3, pen);
        }

        private void button1_Click(object sender, EventArgs e)
        { // zmena hodnot a render po kliknuti

            // inicializace
            iterace = (int)numericUpDown1.Value;
            priblizeni = (int)numericUpDown2.Value;
            hScroll = (double)hScrollBar1.Value / 1000;
            vScroll = (double)vScrollBar1.Value / 1000;
            cRe = (double)numericUpDown3.Value;
            cIm = (double)numericUpDown4.Value;


            // vykresli fraktal dle vyberu
            switch (comboBox1.SelectedIndex)
            {
                case 0: // dragon curve
                    bm = new Bitmap(panel1.Width, panel1.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                    gr = Graphics.FromImage(bm);

                    gr = DragonCurve.DrawDragonLine(gr, iterace, Direction.Right, panel1.Width / 3,
                        panel1.Height / 4, panel1.Width / 2, panel1.Height / 3, pen);
                    break;
                case 1: //mandelbrot
                    bm = Mandelbrot.NakresliMandelbrot(panel1.Width, panel1.Height, iterace, barva, barvaPozadi, priblizeni, hScroll, vScroll);
                    break;
                case 2: // julia
                    bm = Julia.NakresliJulia(panel1.Width, panel1.Height, iterace, barva, barvaPozadi, priblizeni, cRe, cIm, hScroll, vScroll);
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
                button5.BackColor = cd.Color;
            }
        }

        // upravi maximalni pocet iteraci a jine hodnoty u dle zvoleneho fraktalu
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    numericUpDown1.Maximum = 20;
                    numericUpDown1.Value = 10;
                    numericUpDown2.Enabled = false;
                    numericUpDown3.Enabled = false;
                    numericUpDown4.Enabled = false;
                    hScrollBar1.Enabled = false;
                    vScrollBar1.Enabled = false;
                    break;
                case 1:
                    numericUpDown1.Maximum = 500;
                    numericUpDown1.Value = 50;
                    numericUpDown2.Enabled = true;
                    numericUpDown3.Enabled = false;
                    numericUpDown4.Enabled = false;
                    hScrollBar1.Enabled = true;
                    vScrollBar1.Enabled = true;
                    break;
                case 2:
                    numericUpDown1.Maximum = 500;
                    numericUpDown1.Value = 50;
                    numericUpDown2.Enabled = true;
                    numericUpDown3.Enabled = true;
                    numericUpDown4.Enabled = true;
                    hScrollBar1.Enabled = true;
                    vScrollBar1.Enabled = true;
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
            string[] soubor = saveFileDialog1.FileName.Split(".");
            string souborNazev = soubor[0].Insert(58, "\\Parametry\\") + ".txt";

            // otevre streamwriter a ulozi hodnoty dle daneho fraktalu
            StreamWriter sw = new StreamWriter(souborNazev);
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    sw.WriteLine(comboBox1.SelectedIndex);
                    sw.WriteLine(iterace);
                    sw.Close();
                    break;
                case 1:
                    sw.WriteLine(comboBox1.SelectedIndex);
                    sw.WriteLine(iterace);
                    sw.WriteLine(priblizeni);
                    sw.WriteLine(hScroll);
                    sw.WriteLine(vScroll);
                    sw.Close();
                    break;
                case 2:
                    sw.WriteLine(comboBox1.SelectedIndex);
                    sw.WriteLine(iterace);
                    sw.WriteLine(priblizeni);
                    sw.WriteLine(hScroll);
                    sw.WriteLine(vScroll);
                    sw.WriteLine(cRe);
                    sw.WriteLine(cIm);
                    sw.Close();
                    break;
            }
        }

        // otevre openfile dialog
        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        { // nacte bitmapu ulozeneho obrazku a hodnoty pouzite pro jeho generovani ulozene v textovem souboru
            bm = new Bitmap(openFileDialog1.FileName);
            string[] soubor = openFileDialog1.FileName.Split(".");
            string souborNazev = soubor[0].Insert(58, "\\Parametry\\") + ".txt";

            // otevre streamreader
            StreamReader sr = new StreamReader(souborNazev);
            string[] vysledky = sr.ReadToEnd().Split("\n");

            // ulozi hodnoty ze souboru do programu
            comboBox1.SelectedIndex = Convert.ToInt32(vysledky[0]);
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    iterace = Convert.ToInt32(vysledky[1]);
                    numericUpDown1.Value = iterace;
                    break;
                case 1:
                    iterace = Convert.ToInt32(vysledky[1]);
                    numericUpDown1.Value = iterace;
                    priblizeni = Convert.ToInt32(vysledky[2]);
                    numericUpDown2.Value = priblizeni;
                    hScroll = Convert.ToDouble(vysledky[3]);
                    hScrollBar1.Value = (int)(hScroll * 1000);
                    vScroll = Convert.ToDouble(vysledky[4]);
                    vScrollBar1.Value = (int)(vScroll * 1000);
                    break;
                case 2:
                    iterace = Convert.ToInt32(vysledky[1]);
                    numericUpDown1.Value = iterace;
                    priblizeni = Convert.ToInt32(vysledky[2]);
                    numericUpDown2.Value = priblizeni;
                    hScroll = Convert.ToDouble(vysledky[3]);
                    hScrollBar1.Value = (int)(hScroll * 1000);
                    vScroll = Convert.ToDouble(vysledky[4]);
                    vScrollBar1.Value = (int)(vScroll * 1000);
                    cRe = Convert.ToDouble(vysledky[5]);
                    numericUpDown3.Value = (decimal)cRe;
                    cIm = Convert.ToDouble(vysledky[6]);
                    numericUpDown4.Value = (decimal)cIm;
                    break;
            }

            panel1.Invalidate();
        }

        private void label4_Click(object sender, EventArgs e)
        { // snad tohle smazu, jestli ne tak se omlouvam
            MessageBox.Show("Hehe, zde se žádná pomoc nenachází.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                barvaPozadi = cd.Color;
                button7.BackColor = cd.Color;
                panel1.BackColor = cd.Color;
            }
        }
    }
}