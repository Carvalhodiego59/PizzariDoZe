using System.Windows.Forms;

namespace ProjetoDevSistemas2023
{
    partial class sabores
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
            CadastroSABORES = new Label();
            panel1 = new Panel();
            listBoxCategoria = new ListBox();
            listBoxTipo = new ListBox();
            checkedListBoxIngredientes = new CheckedListBox();
            pictureBoxImagem = new PictureBox();
            textBoxNome = new TextBox();
            textBoxID = new TextBox();
            ingredientessabores = new Label();
            fotosabores = new Label();
            tiposabores = new Label();
            categoriasabores = new Label();
            nomesabores = new Label();
            IDsabores = new Label();
            UserControl12 = new UserControl1();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).BeginInit();
            SuspendLayout();
            // 
            // CadastroSABORES
            // 
            CadastroSABORES.AutoSize = true;
            CadastroSABORES.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CadastroSABORES.Location = new Point(0, 0);
            CadastroSABORES.Name = "CadastroSABORES";
            CadastroSABORES.Size = new Size(217, 35);
            CadastroSABORES.TabIndex = 0;
            CadastroSABORES.Text = "Cadastrar Sabores";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(listBoxCategoria);
            panel1.Controls.Add(listBoxTipo);
            panel1.Controls.Add(checkedListBoxIngredientes);
            panel1.Controls.Add(pictureBoxImagem);
            panel1.Controls.Add(textBoxNome);
            panel1.Controls.Add(textBoxID);
            panel1.Controls.Add(ingredientessabores);
            panel1.Controls.Add(fotosabores);
            panel1.Controls.Add(tiposabores);
            panel1.Controls.Add(categoriasabores);
            panel1.Controls.Add(nomesabores);
            panel1.Controls.Add(IDsabores);
            panel1.Location = new Point(12, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(710, 301);
            panel1.TabIndex = 1;
            // 
            // listBoxCategoria
            // 
            listBoxCategoria.FormattingEnabled = true;
            listBoxCategoria.ItemHeight = 20;
            listBoxCategoria.Items.AddRange(new object[] { "Tradicional", "Especial" });
            listBoxCategoria.Location = new Point(225, 117);
            listBoxCategoria.Name = "listBoxCategoria";
            listBoxCategoria.Size = new Size(115, 64);
            listBoxCategoria.TabIndex = 13;
            // 
            // listBoxTipo
            // 
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 20;
            listBoxTipo.Items.AddRange(new object[] { "Doce", "Salgada" });
            listBoxTipo.Location = new Point(225, 212);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(115, 64);
            listBoxTipo.TabIndex = 12;
            // 
            // checkedListBoxIngredientes
            // 
            checkedListBoxIngredientes.BackColor = Color.Gold;
            checkedListBoxIngredientes.FormattingEnabled = true;
            checkedListBoxIngredientes.Items.AddRange(new object[] { "Calabresa", "Frango", "Bacon", "Cheddar", "Catupiry", "Carne", "Carne Seca\t", "Tomate", "Chocolate Preto", "Chocolate Branco", "Sorvete", "Banana Nevada", "Morango", "Brigadeiro", "Prestígio" });
            checkedListBoxIngredientes.Location = new Point(480, 45);
            checkedListBoxIngredientes.Name = "checkedListBoxIngredientes";
            checkedListBoxIngredientes.Size = new Size(197, 246);
            checkedListBoxIngredientes.TabIndex = 11;
            // 
            // pictureBoxImagem
            // 
            pictureBoxImagem.Image = Properties.Resources.pizza;
            pictureBoxImagem.Location = new Point(15, 128);
            pictureBoxImagem.Name = "pictureBoxImagem";
            pictureBoxImagem.Size = new Size(190, 117);
            pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagem.TabIndex = 10;
            pictureBoxImagem.TabStop = false;
            pictureBoxImagem.Click += pictureBoxImagem_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(114, 42);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(332, 27);
            textBoxNome.TabIndex = 2;
            textBoxNome.KeyDown += textBox2_KeyDown;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(15, 42);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(78, 27);
            textBoxID.TabIndex = 1;
            textBoxID.KeyDown += textBox1_KeyDown;
            // 
            // ingredientessabores
            // 
            ingredientessabores.AutoSize = true;
            ingredientessabores.Location = new Point(480, 19);
            ingredientessabores.Name = "ingredientessabores";
            ingredientessabores.Size = new Size(94, 20);
            ingredientessabores.TabIndex = 5;
            ingredientessabores.Text = "Ingredientes:";
            // 
            // fotosabores
            // 
            fotosabores.AutoSize = true;
            fotosabores.Location = new Point(15, 105);
            fotosabores.Name = "fotosabores";
            fotosabores.Size = new Size(42, 20);
            fotosabores.TabIndex = 4;
            fotosabores.Text = "Foto:";
            // 
            // tiposabores
            // 
            tiposabores.AutoSize = true;
            tiposabores.Location = new Point(225, 189);
            tiposabores.Name = "tiposabores";
            tiposabores.Size = new Size(42, 20);
            tiposabores.TabIndex = 3;
            tiposabores.Text = "Tipo:";
            // 
            // categoriasabores
            // 
            categoriasabores.AutoSize = true;
            categoriasabores.Location = new Point(225, 94);
            categoriasabores.Name = "categoriasabores";
            categoriasabores.Size = new Size(77, 20);
            categoriasabores.TabIndex = 2;
            categoriasabores.Text = "Categoria:";
            // 
            // nomesabores
            // 
            nomesabores.AutoSize = true;
            nomesabores.Location = new Point(114, 19);
            nomesabores.Name = "nomesabores";
            nomesabores.Size = new Size(53, 20);
            nomesabores.TabIndex = 1;
            nomesabores.Text = "Nome:";
            // 
            // IDsabores
            // 
            IDsabores.AutoSize = true;
            IDsabores.Location = new Point(15, 19);
            IDsabores.Name = "IDsabores";
            IDsabores.Size = new Size(27, 20);
            IDsabores.TabIndex = 0;
            IDsabores.Text = "ID:";
            // 
            // UserControl12
            // 
            UserControl12.Location = new Point(93, 346);
            UserControl12.Margin = new Padding(3, 4, 3, 4);
            UserControl12.Name = "UserControl12";
            UserControl12.Size = new Size(596, 104);
            UserControl12.TabIndex = 25;
            UserControl12.TabStop = false;
            // 
            // sabores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 463);
            Controls.Add(UserControl12);
            Controls.Add(panel1);
            Controls.Add(CadastroSABORES);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "sabores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sabores";
            KeyDown += sabores_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CadastroSABORES;
        private Panel panel1;
        private PictureBox pictureBoxImagem;
        private TextBox textBoxNome;
        private TextBox textBoxID;
        private Label ingredientessabores;
        private Label fotosabores;
        private Label categoriasabores;
        private Label nomesabores;
        private Label IDsabores;
        private UserControl1 userControl11;
        private UserControl1 UserControl12;
        private Label tiposabores;
        private CheckedListBox checkedListBoxIngredientes;
        private ListBox listBoxCategoria;
        private ListBox listBoxTipo;
    }
}