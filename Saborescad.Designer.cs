namespace ProjetoDevSistemas2023
{
    partial class Saborescad
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
            dataGridViewDados = new DataGridView();
            userControl11 = new UserControl1();
            ButtonPdfCompleto = new Button();
            ButtonPdfSelecionado = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.AllowUserToAddRows = false;
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewDados.Location = new Point(12, 12);
            dataGridViewDados.MultiSelect = false;
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowHeadersWidth = 51;
            dataGridViewDados.RowTemplate.Height = 29;
            dataGridViewDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDados.Size = new Size(776, 426);
            dataGridViewDados.TabIndex = 0;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(234, 446);
            userControl11.Margin = new Padding(3, 5, 3, 5);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(537, 107);
            userControl11.TabIndex = 1;
            // 
            // ButtonPdfCompleto
            // 
            ButtonPdfCompleto.BackColor = SystemColors.ActiveCaptionText;
            ButtonPdfCompleto.FlatStyle = FlatStyle.Flat;
            ButtonPdfCompleto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonPdfCompleto.ForeColor = SystemColors.ControlLightLight;
            ButtonPdfCompleto.Location = new Point(12, 446);
            ButtonPdfCompleto.Name = "ButtonPdfCompleto";
            ButtonPdfCompleto.Size = new Size(71, 43);
            ButtonPdfCompleto.TabIndex = 17;
            ButtonPdfCompleto.Text = "PDF";
            ButtonPdfCompleto.UseVisualStyleBackColor = false;
            ButtonPdfCompleto.Click += ButtonPdfCompleto_Click;
            // 
            // ButtonPdfSelecionado
            // 
            ButtonPdfSelecionado.BackColor = SystemColors.ActiveCaptionText;
            ButtonPdfSelecionado.FlatStyle = FlatStyle.Flat;
            ButtonPdfSelecionado.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonPdfSelecionado.ForeColor = SystemColors.ControlLightLight;
            ButtonPdfSelecionado.Location = new Point(12, 495);
            ButtonPdfSelecionado.Name = "ButtonPdfSelecionado";
            ButtonPdfSelecionado.Size = new Size(216, 47);
            ButtonPdfSelecionado.TabIndex = 18;
            ButtonPdfSelecionado.Text = "PDF Selecionado";
            ButtonPdfSelecionado.UseVisualStyleBackColor = false;
            ButtonPdfSelecionado.Click += ButtonPdfSelecionado_Click;
            // 
            // Saborescad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 554);
            Controls.Add(ButtonPdfSelecionado);
            Controls.Add(ButtonPdfCompleto);
            Controls.Add(userControl11);
            Controls.Add(dataGridViewDados);
            Name = "Saborescad";
            Text = "Saborescad";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewDados;
        private UserControl1 userControl11;
        private Button ButtonPdfCompleto;
        private Button ButtonPdfSelecionado;
    }
}