using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjetoDevSistemas2023
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSalvar = new Button();
            buttonEditar = new Button();
            buttonExcluir = new Button();
            buttonFechar = new Button();
            SuspendLayout();
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.Green;
            buttonSalvar.Cursor = Cursors.Hand;
            buttonSalvar.FlatStyle = FlatStyle.Flat;
            buttonSalvar.Location = new Point(16, 16);
            buttonSalvar.Margin = new Padding(3, 5, 3, 5);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(114, 80);
            buttonSalvar.TabIndex = 0;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            buttonSalvar.KeyDown += buttonSalvar_KeyDown;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.LightSkyBlue;
            buttonEditar.Cursor = Cursors.Hand;
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.Location = new Point(146, 16);
            buttonEditar.Margin = new Padding(3, 5, 3, 5);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(114, 80);
            buttonEditar.TabIndex = 1;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            buttonEditar.KeyDown += buttonEditar_KeyDown;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.Red;
            buttonExcluir.Cursor = Cursors.Hand;
            buttonExcluir.FlatStyle = FlatStyle.Flat;
            buttonExcluir.Location = new Point(276, 16);
            buttonExcluir.Margin = new Padding(3, 5, 3, 5);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(114, 80);
            buttonExcluir.TabIndex = 2;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            buttonExcluir.KeyDown += buttonExcluir_KeyDown;
            // 
            // buttonFechar
            // 
            buttonFechar.BackColor = Color.Black;
            buttonFechar.Cursor = Cursors.Hand;
            buttonFechar.FlatStyle = FlatStyle.Flat;
            buttonFechar.ForeColor = Color.Ivory;
            buttonFechar.Location = new Point(406, 16);
            buttonFechar.Margin = new Padding(3, 5, 3, 5);
            buttonFechar.Name = "buttonFechar";
            buttonFechar.Size = new Size(114, 80);
            buttonFechar.TabIndex = 3;
            buttonFechar.Text = "Fechar";
            buttonFechar.UseVisualStyleBackColor = false;
            buttonFechar.Click += ButtonFechar_Click;
            buttonFechar.KeyDown += buttonFechar_KeyDown;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonFechar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonEditar);
            Controls.Add(buttonSalvar);
            Margin = new Padding(3, 5, 3, 5);
            Name = "UserControl1";
            Size = new Size(531, 107);
            ResumeLayout(false);
        }

        public Button buttonSalvar;
        public Button buttonEditar;
        public Button buttonExcluir;
        public Button buttonFechar;
    }
}
#endregion