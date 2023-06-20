namespace ProjetoDevSistemas2023
{
    partial class produtos
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
            CADPROD = new Label();
            userControl11 = new UserControl1();
            panelCADPROD = new Panel();
            maskedTextBoxVal = new MaskedTextBox();
            listBoxML = new ListBox();
            listBoxTipo = new ListBox();
            textBoxVALPROD = new TextBox();
            textBoxNPROD = new TextBox();
            textBoxIDPROD = new TextBox();
            MLPROd = new Label();
            TIPOPROD = new Label();
            VALorPROD = new Label();
            NomePROD = new Label();
            IDPROD = new Label();
            panelCADPROD.SuspendLayout();
            SuspendLayout();
            // 
            // CADPROD
            // 
            CADPROD.AutoSize = true;
            CADPROD.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CADPROD.Location = new Point(10, 7);
            CADPROD.Name = "CADPROD";
            CADPROD.Size = new Size(204, 28);
            CADPROD.TabIndex = 0;
            CADPROD.Text = "Cadastro De Produtos";
            // 
            // userControl11
            // 
            userControl11.Location = new Point(3, 224);
            userControl11.Margin = new Padding(3, 4, 3, 4);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(459, 82);
            userControl11.TabIndex = 1;
            userControl11.TabStop = false;
            userControl11.Load += userControl11_Load;
            // 
            // panelCADPROD
            // 
            panelCADPROD.BackColor = SystemColors.ControlDarkDark;
            panelCADPROD.Controls.Add(maskedTextBoxVal);
            panelCADPROD.Controls.Add(listBoxML);
            panelCADPROD.Controls.Add(listBoxTipo);
            panelCADPROD.Controls.Add(textBoxVALPROD);
            panelCADPROD.Controls.Add(textBoxNPROD);
            panelCADPROD.Controls.Add(textBoxIDPROD);
            panelCADPROD.Controls.Add(MLPROd);
            panelCADPROD.Controls.Add(TIPOPROD);
            panelCADPROD.Controls.Add(VALorPROD);
            panelCADPROD.Controls.Add(NomePROD);
            panelCADPROD.Controls.Add(IDPROD);
            panelCADPROD.Location = new Point(10, 42);
            panelCADPROD.Margin = new Padding(3, 2, 3, 2);
            panelCADPROD.Name = "panelCADPROD";
            panelCADPROD.Size = new Size(459, 176);
            panelCADPROD.TabIndex = 2;
            // 
            // maskedTextBoxVal
            // 
            maskedTextBoxVal.Location = new Point(14, 115);
            maskedTextBoxVal.Mask = "$000,00";
            maskedTextBoxVal.Name = "maskedTextBoxVal";
            maskedTextBoxVal.Size = new Size(110, 23);
            maskedTextBoxVal.TabIndex = 9;
            maskedTextBoxVal.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // listBoxML
            // 
            listBoxML.FormattingEnabled = true;
            listBoxML.ItemHeight = 15;
            listBoxML.Items.AddRange(new object[] { "150ml", "300ml", "600ml", "1000ml", "1500ml", "2000ml" });
            listBoxML.Location = new Point(303, 28);
            listBoxML.Margin = new Padding(3, 2, 3, 2);
            listBoxML.Name = "listBoxML";
            listBoxML.Size = new Size(132, 94);
            listBoxML.TabIndex = 8;
            // 
            // listBoxTipo
            // 
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 15;
            listBoxTipo.Items.AddRange(new object[] { "Refrigerante", "Cerveja", "Suco", "Água", "Outros" });
            listBoxTipo.Location = new Point(155, 28);
            listBoxTipo.Margin = new Padding(3, 2, 3, 2);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(132, 94);
            listBoxTipo.TabIndex = 7;
            // 
            // textBoxVALPROD
            // 
            textBoxVALPROD.Location = new Point(14, 115);
            textBoxVALPROD.Margin = new Padding(3, 2, 3, 2);
            textBoxVALPROD.Name = "textBoxVALPROD";
            textBoxVALPROD.Size = new Size(110, 23);
            textBoxVALPROD.TabIndex = 5;
            textBoxVALPROD.TextAlign = HorizontalAlignment.Right;
            textBoxVALPROD.KeyDown += textBoxVALPROD_KeyDown;
            // 
            // textBoxNPROD
            // 
            textBoxNPROD.Location = new Point(14, 68);
            textBoxNPROD.Margin = new Padding(3, 2, 3, 2);
            textBoxNPROD.Name = "textBoxNPROD";
            textBoxNPROD.Size = new Size(110, 23);
            textBoxNPROD.TabIndex = 4;
            textBoxNPROD.KeyDown += textBoxNPROD_KeyDown;
            // 
            // textBoxIDPROD
            // 
            textBoxIDPROD.Location = new Point(14, 28);
            textBoxIDPROD.Margin = new Padding(3, 2, 3, 2);
            textBoxIDPROD.Name = "textBoxIDPROD";
            textBoxIDPROD.Size = new Size(57, 23);
            textBoxIDPROD.TabIndex = 1;
            textBoxIDPROD.KeyDown += textBoxIDPROD_KeyDown;
            // 
            // MLPROd
            // 
            MLPROd.AutoSize = true;
            MLPROd.Location = new Point(303, 10);
            MLPROd.Name = "MLPROd";
            MLPROd.Size = new Size(27, 15);
            MLPROd.TabIndex = 4;
            MLPROd.Text = "ML:";
            // 
            // TIPOPROD
            // 
            TIPOPROD.AutoSize = true;
            TIPOPROD.Location = new Point(155, 10);
            TIPOPROD.Name = "TIPOPROD";
            TIPOPROD.Size = new Size(33, 15);
            TIPOPROD.TabIndex = 3;
            TIPOPROD.Text = "Tipo:";
            // 
            // VALorPROD
            // 
            VALorPROD.AutoSize = true;
            VALorPROD.Location = new Point(14, 98);
            VALorPROD.Name = "VALorPROD";
            VALorPROD.Size = new Size(36, 15);
            VALorPROD.TabIndex = 2;
            VALorPROD.Text = "Valor:";
            // 
            // NomePROD
            // 
            NomePROD.AutoSize = true;
            NomePROD.Location = new Point(14, 50);
            NomePROD.Name = "NomePROD";
            NomePROD.Size = new Size(43, 15);
            NomePROD.TabIndex = 1;
            NomePROD.Text = "Nome:";
            // 
            // IDPROD
            // 
            IDPROD.AutoSize = true;
            IDPROD.Location = new Point(14, 10);
            IDPROD.Name = "IDPROD";
            IDPROD.Size = new Size(21, 15);
            IDPROD.TabIndex = 0;
            IDPROD.Text = "ID:";
            // 
            // produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(484, 310);
            Controls.Add(panelCADPROD);
            Controls.Add(userControl11);
            Controls.Add(CADPROD);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "produtos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "produtos";
            Load += produtos_Load;
            KeyDown += produtos_KeyDown;
            panelCADPROD.ResumeLayout(false);
            panelCADPROD.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CADPROD;
        private UserControl1 userControl11;
        private Panel panelCADPROD;
        private TextBox textBoxVALPROD;
        private TextBox textBoxNPROD;
        private TextBox textBoxIDPROD;
        private ComboBox comboBoxml;
        private ComboBox comboBoxTipo;
        private Label MLPROd;
        private Label TIPOPROD;
        private Label VALorPROD;
        private Label NomePROD;
        private Label IDPROD;
        private ListBox listBoxTipo;
        private ListBox listBoxML;
        private MaskedTextBox maskedTextBoxVal;
    }
}