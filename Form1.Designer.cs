namespace Fractals
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            vScrollBar1 = new VScrollBar();
            hScrollBar1 = new HScrollBar();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            colorDialog1 = new ColorDialog();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.0824738F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.4639177F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.3092785F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.6804123F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.4639177F));
            tableLayoutPanel1.Controls.Add(numericUpDown2, 3, 11);
            tableLayoutPanel1.Controls.Add(label3, 3, 10);
            tableLayoutPanel1.Controls.Add(numericUpDown1, 1, 11);
            tableLayoutPanel1.Controls.Add(label1, 1, 10);
            tableLayoutPanel1.Controls.Add(button1, 6, 10);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(comboBox1, 0, 11);
            tableLayoutPanel1.Controls.Add(label2, 0, 10);
            tableLayoutPanel1.Controls.Add(button2, 5, 8);
            tableLayoutPanel1.Controls.Add(button3, 5, 0);
            tableLayoutPanel1.Controls.Add(button4, 5, 3);
            tableLayoutPanel1.Controls.Add(label4, 5, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(978, 744);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            tableLayoutPanel1.SetColumnSpan(numericUpDown2, 2);
            numericUpDown2.Dock = DockStyle.Fill;
            numericUpDown2.Location = new Point(587, 706);
            numericUpDown2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(240, 31);
            numericUpDown2.TabIndex = 8;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label3, 2);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(587, 668);
            label3.Name = "label3";
            label3.Size = new Size(240, 35);
            label3.TabIndex = 7;
            label3.Text = "Přiblížení";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            tableLayoutPanel1.SetColumnSpan(numericUpDown1, 2);
            numericUpDown1.Dock = DockStyle.Fill;
            numericUpDown1.Location = new Point(344, 706);
            numericUpDown1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(237, 31);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(344, 668);
            label1.Name = "label1";
            label1.Size = new Size(237, 35);
            label1.TabIndex = 3;
            label1.Text = "Počet iterací";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(833, 671);
            button1.Name = "button1";
            tableLayoutPanel1.SetRowSpan(button1, 2);
            button1.Size = new Size(142, 70);
            button1.TabIndex = 0;
            button1.Text = "Render";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.SetColumnSpan(panel1, 5);
            panel1.Controls.Add(vScrollBar1);
            panel1.Controls.Add(hScrollBar1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            tableLayoutPanel1.SetRowSpan(panel1, 10);
            panel1.Size = new Size(824, 662);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(804, 0);
            vScrollBar1.Maximum = 1000;
            vScrollBar1.Minimum = -1000;
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(20, 662);
            vScrollBar1.TabIndex = 1;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(0, 642);
            hScrollBar1.Maximum = 0;
            hScrollBar1.Minimum = -1000;
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.RightToLeft = RightToLeft.No;
            hScrollBar1.Size = new Size(804, 20);
            hScrollBar1.TabIndex = 0;
            hScrollBar1.Value = -500;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dragon-curve fraktál", "Mandelbrot fraktál", "Julia-set fraktál" });
            comboBox1.Location = new Point(3, 706);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(335, 33);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(3, 668);
            label2.Name = "label2";
            label2.Size = new Size(335, 35);
            label2.TabIndex = 6;
            label2.Text = "Aktuálně vybraný fraktál:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(833, 568);
            button2.Name = "button2";
            tableLayoutPanel1.SetRowSpan(button2, 2);
            button2.Size = new Size(142, 97);
            button2.TabIndex = 4;
            button2.Text = "Výběr barvy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(833, 3);
            button3.Name = "button3";
            tableLayoutPanel1.SetRowSpan(button3, 3);
            button3.Size = new Size(142, 99);
            button3.TabIndex = 10;
            button3.Text = "Uložit aktuální obrázek";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(833, 108);
            button4.Name = "button4";
            tableLayoutPanel1.SetRowSpan(button4, 3);
            button4.Size = new Size(142, 99);
            button4.TabIndex = 11;
            button4.Text = "Načíst uložený obrázek";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(833, 210);
            label4.Name = "label4";
            label4.Size = new Size(142, 35);
            label4.TabIndex = 12;
            label4.Text = "POMOC";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // colorDialog1
            // 
            colorDialog1.Color = Color.Firebrick;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "bmp";
            saveFileDialog1.FileName = "fraktal";
            saveFileDialog1.Filter = "All files (*.*)|*.*";
            saveFileDialog1.InitialDirectory = "\\\\?\\C:\\Users\\vitve\\AppData\\Local\\Microsoft\\VisualStudio\\17.0_e8266c70\\WinFormsDesigner\\grzxnba4.pq2\\Ulozene\\";
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.InitialDirectory = "\\\\?\\C:\\Users\\vitve\\AppData\\Local\\Microsoft\\VisualStudio\\17.0_e8266c70\\WinFormsDesigner\\5zt41tp5.zyd\\Ulozene\\";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(978, 744);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(1000, 800);
            MinimumSize = new Size(1000, 800);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generátor fraktálů";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Panel panel1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Button button2;
        private ColorDialog colorDialog1;
        private ComboBox comboBox1;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private Button button3;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button button4;
        private HScrollBar hScrollBar1;
        private VScrollBar vScrollBar1;
        private Label label4;
    }
}