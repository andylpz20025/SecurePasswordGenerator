namespace SecurePasswordGenerator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            numBlocks = new NumericUpDown();
            numCharsPerBlock = new NumericUpDown();
            txtSeparator = new TextBox();
            chkUpper = new CheckBox();
            chkLower = new CheckBox();
            chkDigits = new CheckBox();
            chkSpecial = new CheckBox();
            chkUmlauts = new CheckBox();
            btnGenerate = new Button();
            txtOutput = new TextBox();
            laenge = new Label();
            bloecke = new Label();
            trennzeichen = new Label();
            anleitung = new Label();
            ((System.ComponentModel.ISupportInitialize)numBlocks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCharsPerBlock).BeginInit();
            SuspendLayout();
            // 
            // numBlocks
            // 
            numBlocks.Location = new Point(319, 54);
            numBlocks.Name = "numBlocks";
            numBlocks.Size = new Size(120, 31);
            numBlocks.TabIndex = 0;
            numBlocks.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // numCharsPerBlock
            // 
            numCharsPerBlock.Location = new Point(319, 84);
            numCharsPerBlock.Name = "numCharsPerBlock";
            numCharsPerBlock.Size = new Size(120, 31);
            numCharsPerBlock.TabIndex = 1;
            numCharsPerBlock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtSeparator
            // 
            txtSeparator.Location = new Point(319, 114);
            txtSeparator.Name = "txtSeparator";
            txtSeparator.Size = new Size(50, 31);
            txtSeparator.TabIndex = 2;
            txtSeparator.Text = "-";
            // 
            // chkUpper
            // 
            chkUpper.AutoSize = true;
            chkUpper.Location = new Point(42, 16);
            chkUpper.Name = "chkUpper";
            chkUpper.Size = new Size(169, 29);
            chkUpper.TabIndex = 3;
            chkUpper.Text = "Großbuchstaben";
            // 
            // chkLower
            // 
            chkLower.AutoSize = true;
            chkLower.Location = new Point(42, 41);
            chkLower.Name = "chkLower";
            chkLower.Size = new Size(167, 29);
            chkLower.TabIndex = 4;
            chkLower.Text = "Kleinbuchstaben";
            // 
            // chkDigits
            // 
            chkDigits.AutoSize = true;
            chkDigits.Location = new Point(42, 66);
            chkDigits.Name = "chkDigits";
            chkDigits.Size = new Size(89, 29);
            chkDigits.TabIndex = 5;
            chkDigits.Text = "Ziffern";
            // 
            // chkSpecial
            // 
            chkSpecial.AutoSize = true;
            chkSpecial.Location = new Point(42, 91);
            chkSpecial.Name = "chkSpecial";
            chkSpecial.Size = new Size(153, 29);
            chkSpecial.TabIndex = 6;
            chkSpecial.Text = "Sonderzeichen";
            // 
            // chkUmlauts
            // 
            chkUmlauts.AutoSize = true;
            chkUmlauts.Location = new Point(42, 116);
            chkUmlauts.Name = "chkUmlauts";
            chkUmlauts.Size = new Size(104, 29);
            chkUmlauts.TabIndex = 7;
            chkUmlauts.Text = "Umlaute";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(42, 156);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(180, 40);
            btnGenerate.TabIndex = 8;
            btnGenerate.Text = "Generieren";
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(42, 206);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(400, 31);
            txtOutput.TabIndex = 9;
            // 
            // laenge
            // 
            laenge.AutoSize = true;
            laenge.Location = new Point(250, 56);
            laenge.Name = "laenge";
            laenge.Size = new Size(63, 25);
            laenge.TabIndex = 10;
            laenge.Text = "Länge:";
            laenge.Click += label1_Click;
            // 
            // bloecke
            // 
            bloecke.AutoSize = true;
            bloecke.Location = new Point(250, 86);
            bloecke.Name = "bloecke";
            bloecke.Size = new Size(67, 25);
            bloecke.TabIndex = 11;
            bloecke.Text = "Blöcke:";
            // 
            // trennzeichen
            // 
            trennzeichen.AutoSize = true;
            trennzeichen.Location = new Point(196, 117);
            trennzeichen.Name = "trennzeichen";
            trennzeichen.Size = new Size(116, 25);
            trennzeichen.TabIndex = 12;
            trennzeichen.Text = "Trennzeichen:";
            // 
            // anleitung
            // 
            anleitung.AutoSize = true;
            anleitung.Location = new Point(471, 9);
            anleitung.Name = "anleitung";
            anleitung.Size = new Size(831, 325);
            anleitung.TabIndex = 13;
            anleitung.Text = resources.GetString("anleitung.Text");
            anleitung.Click += label2_Click;
            // 
            // Form1
            // 
            BackColor = Color.Lavender;
            ClientSize = new Size(1317, 360);
            Controls.Add(anleitung);
            Controls.Add(trennzeichen);
            Controls.Add(bloecke);
            Controls.Add(laenge);
            Controls.Add(numBlocks);
            Controls.Add(numCharsPerBlock);
            Controls.Add(txtSeparator);
            Controls.Add(chkUpper);
            Controls.Add(chkLower);
            Controls.Add(chkDigits);
            Controls.Add(chkSpecial);
            Controls.Add(chkUmlauts);
            Controls.Add(btnGenerate);
            Controls.Add(txtOutput);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)numBlocks).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCharsPerBlock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.NumericUpDown numBlocks;
        private System.Windows.Forms.NumericUpDown numCharsPerBlock;
        private System.Windows.Forms.TextBox txtSeparator;
        private System.Windows.Forms.CheckBox chkUpper;
        private System.Windows.Forms.CheckBox chkLower;
        private System.Windows.Forms.CheckBox chkDigits;
        private System.Windows.Forms.CheckBox chkSpecial;
        private System.Windows.Forms.CheckBox chkUmlauts;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtOutput;
        private Label laenge;
        private Label bloecke;
        private Label trennzeichen;
        private Label anleitung;
    }
}