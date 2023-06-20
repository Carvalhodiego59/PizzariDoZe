namespace ProjetoDevSistemas2023
{
    partial class ingredientes
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
            CadastroING = new Label();
            panel1 = new Panel();
            textBoxNOMEING = new TextBox();
            textBoxIDING = new TextBox();
            NomeING = new Label();
            IDING = new Label();
            userControl12 = new UserControl1();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CadastroING
            // 
            CadastroING.AutoSize = true;
            CadastroING.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CadastroING.Location = new Point(0, 0);
            CadastroING.Name = "CadastroING";
            CadastroING.Size = new Size(297, 35);
            CadastroING.TabIndex = 0;
            CadastroING.Text = "Cadastro De Ingredientes";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(textBoxNOMEING);
            panel1.Controls.Add(textBoxIDING);
            panel1.Controls.Add(NomeING);
            panel1.Controls.Add(IDING);
            panel1.Location = new Point(12, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 125);
            panel1.TabIndex = 1;
            // 
            // textBoxNOMEING
            // 
            textBoxNOMEING.Location = new Point(112, 42);
            textBoxNOMEING.Name = "textBoxNOMEING";
            textBoxNOMEING.Size = new Size(429, 27);
            textBoxNOMEING.TabIndex = 2;
            textBoxNOMEING.TextChanged += textBoxNOMEING_TextChanged;
            textBoxNOMEING.KeyDown += textBoxNOMEING_KeyDown;
            // 
            // textBoxIDING
            // 
            textBoxIDING.Location = new Point(14, 42);
            textBoxIDING.Name = "textBoxIDING";
            textBoxIDING.Size = new Size(64, 27);
            textBoxIDING.TabIndex = 1;
            textBoxIDING.TextChanged += textBoxIDING_TextChanged;
            textBoxIDING.KeyDown += textBoxIDING_KeyDown;
            // 
            // NomeING
            // 
            NomeING.AutoSize = true;
            NomeING.Location = new Point(112, 19);
            NomeING.Name = "NomeING";
            NomeING.Size = new Size(53, 20);
            NomeING.TabIndex = 2;
            NomeING.Text = "Nome:";
            // 
            // IDING
            // 
            IDING.AutoSize = true;
            IDING.BackColor = Color.Firebrick;
            IDING.Location = new Point(14, 19);
            IDING.Name = "IDING";
            IDING.Size = new Size(27, 20);
            IDING.TabIndex = 0;
            IDING.Text = "ID:";
            // 
            // userControl12
            // 
            userControl12.Location = new Point(0, 170);
            userControl12.Margin = new Padding(3, 4, 3, 4);
            userControl12.Name = "userControl12";
            userControl12.Size = new Size(553, 117);
            userControl12.TabIndex = 3;
            userControl12.TabStop = false;
            userControl12.Load += userControl12_Load;
            // 
            // ingredientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 285);
            Controls.Add(userControl12);
            Controls.Add(panel1);
            Controls.Add(CadastroING);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ingredientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ingredientes";
            Load += ingredientes_Load;
            KeyDown += ingredientes_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CadastroING;
        private Panel panel1;
        private TextBox textBoxNOMEING;
        private TextBox textBoxIDING;
        private Label NomeING;
        private Label IDING;
        private UserControl1 userControl12;
    }
}