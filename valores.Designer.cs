namespace ProjetoDevSistemas2023
{
    partial class valores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CadastroVal = new Label();
            CADid = new Label();
            panel1 = new Panel();
            maskedTextBoxVAB = new MaskedTextBox();
            maskedTextBoxVal = new MaskedTextBox();
            listBoxTamanho = new ListBox();
            listBoxCategoria = new ListBox();
            CADCAT = new Label();
            CADTAM = new Label();
            textBoxVAB = new TextBox();
            textBoxVAL = new TextBox();
            textBoxID = new TextBox();
            CADVAB = new Label();
            CADVAL = new Label();
            userControl11 = new UserControl1();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CadastroVal
            // 
            CadastroVal.AutoSize = true;
            CadastroVal.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CadastroVal.Location = new Point(11, 9);
            CadastroVal.Name = "CadastroVal";
            CadastroVal.Size = new Size(240, 35);
            CadastroVal.TabIndex = 0;
            CadastroVal.Text = "Cadastro De Valores";
            // 
            // CADid
            // 
            CADid.AutoSize = true;
            CADid.Location = new Point(18, 15);
            CADid.Name = "CADid";
            CADid.Size = new Size(27, 20);
            CADid.TabIndex = 2;
            CADid.Text = "ID:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(maskedTextBoxVAB);
            panel1.Controls.Add(maskedTextBoxVal);
            panel1.Controls.Add(listBoxTamanho);
            panel1.Controls.Add(listBoxCategoria);
            panel1.Controls.Add(CADCAT);
            panel1.Controls.Add(CADTAM);
            panel1.Controls.Add(textBoxVAB);
            panel1.Controls.Add(textBoxVAL);
            panel1.Controls.Add(textBoxID);
            panel1.Controls.Add(CADVAB);
            panel1.Controls.Add(CADVAL);
            panel1.Controls.Add(CADid);
            panel1.Location = new Point(11, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 231);
            panel1.TabIndex = 3;
            // 
            // maskedTextBoxVAB
            // 
            maskedTextBoxVAB.Location = new Point(18, 165);
            maskedTextBoxVAB.Mask = "$000,00";
            maskedTextBoxVAB.Name = "maskedTextBoxVAB";
            maskedTextBoxVAB.Size = new Size(105, 27);
            maskedTextBoxVAB.TabIndex = 11;
            maskedTextBoxVAB.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxVal
            // 
            maskedTextBoxVal.Location = new Point(18, 103);
            maskedTextBoxVal.Mask = "$000,00";
            maskedTextBoxVal.Name = "maskedTextBoxVal";
            maskedTextBoxVal.Size = new Size(105, 27);
            maskedTextBoxVal.TabIndex = 10;
            maskedTextBoxVal.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // listBoxTamanho
            // 
            listBoxTamanho.FormattingEnabled = true;
            listBoxTamanho.ItemHeight = 20;
            listBoxTamanho.Items.AddRange(new object[] { "Pequena", "Media", "Grande", "Família" });
            listBoxTamanho.Location = new Point(200, 37);
            listBoxTamanho.Name = "listBoxTamanho";
            listBoxTamanho.Size = new Size(150, 184);
            listBoxTamanho.TabIndex = 5;
            // 
            // listBoxCategoria
            // 
            listBoxCategoria.FormattingEnabled = true;
            listBoxCategoria.ItemHeight = 20;
            listBoxCategoria.Items.AddRange(new object[] { "Tradicional", "Especial" });
            listBoxCategoria.Location = new Point(373, 37);
            listBoxCategoria.Name = "listBoxCategoria";
            listBoxCategoria.Size = new Size(150, 184);
            listBoxCategoria.TabIndex = 6;
            // 
            // CADCAT
            // 
            CADCAT.AutoSize = true;
            CADCAT.Location = new Point(373, 15);
            CADCAT.Name = "CADCAT";
            CADCAT.Size = new Size(77, 20);
            CADCAT.TabIndex = 9;
            CADCAT.Text = "Categoria:";
            // 
            // CADTAM
            // 
            CADTAM.AutoSize = true;
            CADTAM.Location = new Point(200, 15);
            CADTAM.Name = "CADTAM";
            CADTAM.Size = new Size(72, 20);
            CADTAM.TabIndex = 8;
            CADTAM.Text = "Tamanho:";
            // 
            // textBoxVAB
            // 
            textBoxVAB.Location = new Point(18, 165);
            textBoxVAB.Name = "textBoxVAB";
            textBoxVAB.Size = new Size(105, 27);
            textBoxVAB.TabIndex = 5;
            textBoxVAB.KeyDown += textBoxVAB_KeyDown;
            // 
            // textBoxVAL
            // 
            textBoxVAL.Location = new Point(18, 103);
            textBoxVAL.Name = "textBoxVAL";
            textBoxVAL.Size = new Size(105, 27);
            textBoxVAL.TabIndex = 4;
            textBoxVAL.KeyDown += textBoxVAL_KeyDown;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(18, 37);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(73, 27);
            textBoxID.TabIndex = 1;
            textBoxID.KeyDown += textBoxID_KeyDown;
            // 
            // CADVAB
            // 
            CADVAB.AutoSize = true;
            CADVAB.Location = new Point(18, 141);
            CADVAB.Name = "CADVAB";
            CADVAB.Size = new Size(153, 20);
            CADVAB.TabIndex = 4;
            CADVAB.Text = "Valor Adcional Borda:";
            // 
            // CADVAL
            // 
            CADVAL.AutoSize = true;
            CADVAL.BackColor = Color.SlateGray;
            CADVAL.Location = new Point(18, 80);
            CADVAL.Name = "CADVAL";
            CADVAL.Size = new Size(46, 20);
            CADVAL.TabIndex = 3;
            CADVAL.Text = "Valor:";
            // 
            // userControl11
            // 
            userControl11.Location = new Point(11, 285);
            userControl11.Margin = new Padding(3, 5, 3, 5);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(543, 115);
            userControl11.TabIndex = 4;
            userControl11.TabStop = false;
            // 
            // valores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(571, 399);
            Controls.Add(userControl11);
            Controls.Add(panel1);
            Controls.Add(CadastroVal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "valores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "valores";
            Load += valores_Load;
            KeyDown += valores_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CadastroVal;
        private Label CADid;
        private Panel panel1;
        private Label CADVAB;
        private Label CADVAL;
        private UserControl1 userControl11;
        private Label CADTAM;
        private TextBox textBoxVAB;
        private TextBox textBoxVAL;
        private TextBox textBoxID;
        private Label CADCAT;
        private ListBox listBoxTamanho;
        private ListBox listBoxCategoria;
        private MaskedTextBox maskedTextBoxVal;
        private MaskedTextBox maskedTextBoxVAB;
    }
}