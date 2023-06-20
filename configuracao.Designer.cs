namespace ProjetoDevSistemas2023
{
    partial class configuracao
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
            idiomaregiao = new Label();
            labelidiomaregiao = new Label();
            panel1 = new Panel();
            checkBoxidiomaregiao = new CheckBox();
            CBidiomaregiao = new ComboBox();
            buttonSalvarIdioma = new Button();
            panel2 = new Panel();
            textBoxStringDeConexao = new TextBox();
            stringdeconexao = new Label();
            Provider = new Label();
            comboBoxProvider = new ComboBox();
            buttonsalvardados = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // idiomaregiao
            // 
            idiomaregiao.AutoSize = true;
            idiomaregiao.Location = new Point(0, 0);
            idiomaregiao.Name = "idiomaregiao";
            idiomaregiao.Size = new Size(109, 20);
            idiomaregiao.TabIndex = 1;
            idiomaregiao.Text = "Idioma/Região";
            // 
            // labelidiomaregiao
            // 
            labelidiomaregiao.AutoSize = true;
            labelidiomaregiao.Location = new Point(16, 13);
            labelidiomaregiao.Name = "labelidiomaregiao";
            labelidiomaregiao.Size = new Size(109, 20);
            labelidiomaregiao.TabIndex = 2;
            labelidiomaregiao.Text = "Idioma/Região";
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxidiomaregiao);
            panel1.Controls.Add(CBidiomaregiao);
            panel1.Controls.Add(labelidiomaregiao);
            panel1.Location = new Point(11, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 107);
            panel1.TabIndex = 4;
            // 
            // checkBoxidiomaregiao
            // 
            checkBoxidiomaregiao.AutoSize = true;
            checkBoxidiomaregiao.Location = new Point(205, 51);
            checkBoxidiomaregiao.Name = "checkBoxidiomaregiao";
            checkBoxidiomaregiao.Size = new Size(426, 24);
            checkBoxidiomaregiao.TabIndex = 4;
            checkBoxidiomaregiao.TabStop = false;
            checkBoxidiomaregiao.Text = "Reiniciar programa para estabelecer a linguagem escolhida";
            checkBoxidiomaregiao.UseVisualStyleBackColor = true;
            checkBoxidiomaregiao.KeyDown += checkBoxidiomaregiao_KeyDown;
            // 
            // CBidiomaregiao
            // 
            CBidiomaregiao.FormattingEnabled = true;
            CBidiomaregiao.Items.AddRange(new object[] { "pt-br", "en-US", "es" });
            CBidiomaregiao.Location = new Point(16, 49);
            CBidiomaregiao.Name = "CBidiomaregiao";
            CBidiomaregiao.Size = new Size(155, 28);
            CBidiomaregiao.TabIndex = 3;
            CBidiomaregiao.TabStop = false;
            CBidiomaregiao.Text = "Selecione o Idioma";
            CBidiomaregiao.KeyDown += CBidiomaregiao_KeyDown;
            // 
            // buttonSalvarIdioma
            // 
            buttonSalvarIdioma.BackColor = Color.Green;
            buttonSalvarIdioma.Cursor = Cursors.Hand;
            buttonSalvarIdioma.FlatStyle = FlatStyle.Flat;
            buttonSalvarIdioma.Location = new Point(14, 353);
            buttonSalvarIdioma.Margin = new Padding(3, 5, 3, 5);
            buttonSalvarIdioma.Name = "buttonSalvarIdioma";
            buttonSalvarIdioma.Size = new Size(271, 80);
            buttonSalvarIdioma.TabIndex = 5;
            buttonSalvarIdioma.TabStop = false;
            buttonSalvarIdioma.Text = "Salvar Idioma";
            buttonSalvarIdioma.UseVisualStyleBackColor = false;
            buttonSalvarIdioma.Click += buttonSalvarIdioma_Click;
            buttonSalvarIdioma.KeyDown += buttonSalvarIdioma_KeyDown;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxStringDeConexao);
            panel2.Controls.Add(stringdeconexao);
            panel2.Controls.Add(Provider);
            panel2.Controls.Add(comboBoxProvider);
            panel2.Location = new Point(11, 164);
            panel2.Name = "panel2";
            panel2.Size = new Size(631, 169);
            panel2.TabIndex = 6;
            // 
            // textBoxStringDeConexao
            // 
            textBoxStringDeConexao.Location = new Point(3, 111);
            textBoxStringDeConexao.Name = "textBoxStringDeConexao";
            textBoxStringDeConexao.Size = new Size(623, 27);
            textBoxStringDeConexao.TabIndex = 3;
            // 
            // stringdeconexao
            // 
            stringdeconexao.AutoSize = true;
            stringdeconexao.Location = new Point(21, 88);
            stringdeconexao.Name = "stringdeconexao";
            stringdeconexao.Size = new Size(133, 20);
            stringdeconexao.TabIndex = 2;
            stringdeconexao.Text = "String De Conexão";
            // 
            // Provider
            // 
            Provider.AutoSize = true;
            Provider.Location = new Point(21, 9);
            Provider.Name = "Provider";
            Provider.Size = new Size(64, 20);
            Provider.TabIndex = 1;
            Provider.Text = "Provider";
            // 
            // comboBoxProvider
            // 
            comboBoxProvider.FormattingEnabled = true;
            comboBoxProvider.Items.AddRange(new object[] { "System.Data.SqlClient" });
            comboBoxProvider.Location = new Point(3, 32);
            comboBoxProvider.Name = "comboBoxProvider";
            comboBoxProvider.Size = new Size(230, 28);
            comboBoxProvider.TabIndex = 0;
            // 
            // buttonsalvardados
            // 
            buttonsalvardados.BackColor = Color.Green;
            buttonsalvardados.FlatStyle = FlatStyle.Flat;
            buttonsalvardados.Location = new Point(361, 353);
            buttonsalvardados.Name = "buttonsalvardados";
            buttonsalvardados.Size = new Size(281, 80);
            buttonsalvardados.TabIndex = 7;
            buttonsalvardados.Text = "Salvar Dados";
            buttonsalvardados.UseVisualStyleBackColor = false;
            buttonsalvardados.Click += buttonsalvardados_Click;
            // 
            // configuracao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 451);
            Controls.Add(buttonsalvardados);
            Controls.Add(panel2);
            Controls.Add(buttonSalvarIdioma);
            Controls.Add(panel1);
            Controls.Add(idiomaregiao);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "configuracao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuração";
            Load += configuracao_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label idiomaregiao;
        private Label labelidiomaregiao;
        private Panel panel1;
        private CheckBox checkBoxidiomaregiao;
        private ComboBox CBidiomaregiao;
        public Button buttonSalvarIdioma;
        private Panel panel2;
        private Label Provider;
        private ComboBox comboBoxProvider;
        private Label stringdeconexao;
        private TextBox textBoxStringDeConexao;
        private Button buttonsalvardados;
    }
}