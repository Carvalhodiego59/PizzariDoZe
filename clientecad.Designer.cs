namespace ProjetoDevSistemas2023
{
    partial class clientecad
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
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(12, 12);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowHeadersWidth = 51;
            dataGridViewDados.RowTemplate.Height = 29;
            dataGridViewDados.Size = new Size(776, 324);
            dataGridViewDados.TabIndex = 0;
            dataGridViewDados.CellContentClick += dataGridViewDados_CellContentClick;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(142, 344);
            userControl11.Margin = new Padding(3, 5, 3, 5);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(538, 105);
            userControl11.TabIndex = 1;
            // 
            // clientecad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userControl11);
            Controls.Add(dataGridViewDados);
            Name = "clientecad";
            Text = "clientecad";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewDados;
        private UserControl1 userControl11;
    }
}