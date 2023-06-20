namespace ProjetoDevSistemas2023
{
    partial class ingredientescadastrados
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.AllowUserToOrderColumns = true;
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(80, 28);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowHeadersWidth = 51;
            dataGridViewDados.RowTemplate.Height = 29;
            dataGridViewDados.Size = new Size(396, 284);
            dataGridViewDados.TabIndex = 0;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(12, 320);
            userControl11.Margin = new Padding(3, 5, 3, 5);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(534, 116);
            userControl11.TabIndex = 1;
            // 
            // ingredientescadastrados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 450);
            Controls.Add(userControl11);
            Controls.Add(dataGridViewDados);
            Name = "ingredientescadastrados";
            Text = "ingredientescadastrados";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewDados;
        private UserControl1 userControl11;
    }
}