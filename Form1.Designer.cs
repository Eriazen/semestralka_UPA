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
            button1 = new Button();
            panel1 = new Panel();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            colorDialog1 = new ColorDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.01294F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.98706F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 158F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 139F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 139F));
            tableLayoutPanel1.Controls.Add(button1, 5, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(numericUpDown1, 3, 2);
            tableLayoutPanel1.Controls.Add(label1, 3, 1);
            tableLayoutPanel1.Controls.Add(button2, 2, 1);
            tableLayoutPanel1.Controls.Add(comboBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 94.1678543F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.832148F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(978, 744);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(841, 665);
            button1.Name = "button1";
            tableLayoutPanel1.SetRowSpan(button1, 2);
            button1.Size = new Size(134, 76);
            button1.TabIndex = 0;
            button1.Text = "Render";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            tableLayoutPanel1.SetColumnSpan(panel1, 5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(972, 656);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Dock = DockStyle.Fill;
            numericUpDown1.Location = new Point(702, 706);
            numericUpDown1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(133, 31);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(702, 662);
            label1.Name = "label1";
            label1.Size = new Size(133, 41);
            label1.TabIndex = 3;
            label1.Text = "Počet iterací";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(544, 665);
            button2.Name = "button2";
            tableLayoutPanel1.SetRowSpan(button2, 2);
            button2.Size = new Size(152, 76);
            button2.TabIndex = 4;
            button2.Text = "Výběr barvy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dragon-curve fraktál", "Mandelbrot fraktál", "Julia-set fraktál" });
            comboBox1.Location = new Point(3, 706);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(389, 33);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(3, 662);
            label2.Name = "label2";
            label2.Size = new Size(389, 41);
            label2.TabIndex = 6;
            label2.Text = "Aktuálně vybraný fraktál:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // colorDialog1
            // 
            colorDialog1.Color = Color.Firebrick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
    }
}