using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Resources;

namespace ProjetoDevSistemas2023
{
    partial class PaginaInicialDoZe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaInicialDoZe));
            PIZZARIADOZE = new Label();
            FUNCIONÁRIOS1 = new Button();
            CLIENTES1 = new Button();
            INGREDIENTES1 = new Button();
            SABORES1 = new Button();
            CadastroValores = new Button();
            CadastroProdutos = new Button();
            buttonConfiguracao = new Button();
            contextMenuStripPrincipal = new ContextMenuStrip(components);
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            ingredienteToolStripMenuItem = new ToolStripMenuItem();
            saboresToolStripMenuItem = new ToolStripMenuItem();
            valoresToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            configuraçãoToolStripMenuItem = new ToolStripMenuItem();
            IngredientesCadastrados = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            notifyIconSystemTray = new NotifyIcon(components);
            contextMenuStripSystemTray = new ContextMenuStrip(components);
            abrirAplicaçãoToolStripMenuItem = new ToolStripMenuItem();
            encerrarToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            ingCad = new Button();
            buttonenderecos = new Button();
            Clientescad = new Button();
            Funcionariocad = new Button();
            saborescad = new Button();
            Valorescad = new Button();
            ProdCad = new Button();
            contextMenuStripPrincipal.SuspendLayout();
            contextMenuStripSystemTray.SuspendLayout();
            SuspendLayout();
            // 
            // PIZZARIADOZE
            // 
            PIZZARIADOZE.AutoSize = true;
            PIZZARIADOZE.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            PIZZARIADOZE.Location = new Point(313, 9);
            PIZZARIADOZE.Name = "PIZZARIADOZE";
            PIZZARIADOZE.Size = new Size(511, 100);
            PIZZARIADOZE.TabIndex = 0;
            PIZZARIADOZE.Text = "Pizzaria Do Ze";
            // 
            // FUNCIONÁRIOS1
            // 
            FUNCIONÁRIOS1.BackColor = SystemColors.ControlLightLight;
            FUNCIONÁRIOS1.Cursor = Cursors.Hand;
            FUNCIONÁRIOS1.FlatStyle = FlatStyle.Flat;
            FUNCIONÁRIOS1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            FUNCIONÁRIOS1.Location = new Point(293, 123);
            FUNCIONÁRIOS1.Name = "FUNCIONÁRIOS1";
            FUNCIONÁRIOS1.Size = new Size(275, 85);
            FUNCIONÁRIOS1.TabIndex = 1;
            FUNCIONÁRIOS1.TabStop = false;
            FUNCIONÁRIOS1.Text = "Funcionários";
            FUNCIONÁRIOS1.UseVisualStyleBackColor = false;
            FUNCIONÁRIOS1.Click += buttonFuncionarios_Click;
            FUNCIONÁRIOS1.KeyDown += FUNCIONÁRIOS1_KeyDown;
            // 
            // CLIENTES1
            // 
            CLIENTES1.BackColor = SystemColors.ControlLightLight;
            CLIENTES1.Cursor = Cursors.Hand;
            CLIENTES1.FlatStyle = FlatStyle.Flat;
            CLIENTES1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CLIENTES1.Location = new Point(293, 213);
            CLIENTES1.Name = "CLIENTES1";
            CLIENTES1.Size = new Size(275, 89);
            CLIENTES1.TabIndex = 2;
            CLIENTES1.TabStop = false;
            CLIENTES1.Text = "Clientes";
            CLIENTES1.UseVisualStyleBackColor = false;
            CLIENTES1.Click += buttonClientes_Click;
            CLIENTES1.KeyDown += CLIENTES1_KeyDown;
            // 
            // INGREDIENTES1
            // 
            INGREDIENTES1.BackColor = SystemColors.ControlLightLight;
            INGREDIENTES1.Cursor = Cursors.Hand;
            INGREDIENTES1.FlatStyle = FlatStyle.Flat;
            INGREDIENTES1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            INGREDIENTES1.Location = new Point(574, 123);
            INGREDIENTES1.Name = "INGREDIENTES1";
            INGREDIENTES1.Size = new Size(275, 87);
            INGREDIENTES1.TabIndex = 3;
            INGREDIENTES1.TabStop = false;
            INGREDIENTES1.Text = "Ingredientes";
            INGREDIENTES1.UseVisualStyleBackColor = false;
            INGREDIENTES1.Click += buttonIngredientes_Click;
            INGREDIENTES1.KeyDown += INGREDIENTES1_KeyDown;
            // 
            // SABORES1
            // 
            SABORES1.BackColor = SystemColors.ControlLightLight;
            SABORES1.Cursor = Cursors.Hand;
            SABORES1.FlatStyle = FlatStyle.Flat;
            SABORES1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SABORES1.Location = new Point(574, 219);
            SABORES1.Name = "SABORES1";
            SABORES1.Size = new Size(275, 85);
            SABORES1.TabIndex = 4;
            SABORES1.TabStop = false;
            SABORES1.Text = "Sabores";
            SABORES1.UseVisualStyleBackColor = false;
            SABORES1.Click += buttonSabores_Click;
            SABORES1.KeyDown += SABORES1_KeyDown;
            // 
            // CadastroValores
            // 
            CadastroValores.BackColor = SystemColors.ControlLightLight;
            CadastroValores.FlatStyle = FlatStyle.Flat;
            CadastroValores.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CadastroValores.Location = new Point(293, 309);
            CadastroValores.Name = "CadastroValores";
            CadastroValores.Size = new Size(275, 89);
            CadastroValores.TabIndex = 5;
            CadastroValores.TabStop = false;
            CadastroValores.Text = "Valores";
            CadastroValores.UseVisualStyleBackColor = false;
            CadastroValores.Click += CadastroValores_Click;
            CadastroValores.KeyDown += CadastroValores_KeyDown;
            // 
            // CadastroProdutos
            // 
            CadastroProdutos.BackColor = SystemColors.ControlLightLight;
            CadastroProdutos.FlatStyle = FlatStyle.Flat;
            CadastroProdutos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CadastroProdutos.Location = new Point(574, 309);
            CadastroProdutos.Name = "CadastroProdutos";
            CadastroProdutos.Size = new Size(275, 87);
            CadastroProdutos.TabIndex = 6;
            CadastroProdutos.TabStop = false;
            CadastroProdutos.Text = "Produtos";
            CadastroProdutos.UseVisualStyleBackColor = false;
            CadastroProdutos.Click += CadastroProdutos_Click;
            CadastroProdutos.KeyDown += CadastroProdutos_KeyDown;
            // 
            // buttonConfiguracao
            // 
            buttonConfiguracao.BackColor = SystemColors.ControlLightLight;
            buttonConfiguracao.FlatStyle = FlatStyle.Flat;
            buttonConfiguracao.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfiguracao.Location = new Point(11, 357);
            buttonConfiguracao.Name = "buttonConfiguracao";
            buttonConfiguracao.Size = new Size(275, 91);
            buttonConfiguracao.TabIndex = 8;
            buttonConfiguracao.TabStop = false;
            buttonConfiguracao.Text = "Configurações";
            buttonConfiguracao.UseVisualStyleBackColor = false;
            buttonConfiguracao.Click += buttonconfig_Click;
            buttonConfiguracao.KeyDown += buttonConfiguracao_KeyDown;
            // 
            // contextMenuStripPrincipal
            // 
            contextMenuStripPrincipal.ImageScalingSize = new Size(20, 20);
            contextMenuStripPrincipal.Items.AddRange(new ToolStripItem[] { funcionárioToolStripMenuItem, clienteToolStripMenuItem, ingredienteToolStripMenuItem, saboresToolStripMenuItem, valoresToolStripMenuItem, produtosToolStripMenuItem, configuraçãoToolStripMenuItem, IngredientesCadastrados, sairToolStripMenuItem });
            contextMenuStripPrincipal.Name = "contextMenuStripPrincipal";
            contextMenuStripPrincipal.Size = new Size(311, 220);
            contextMenuStripPrincipal.Text = "aaaaaa";
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F2;
            funcionárioToolStripMenuItem.Size = new Size(310, 24);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F3;
            clienteToolStripMenuItem.Size = new Size(310, 24);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // ingredienteToolStripMenuItem
            // 
            ingredienteToolStripMenuItem.Name = "ingredienteToolStripMenuItem";
            ingredienteToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F4;
            ingredienteToolStripMenuItem.Size = new Size(310, 24);
            ingredienteToolStripMenuItem.Text = "Ingrediente";
            // 
            // saboresToolStripMenuItem
            // 
            saboresToolStripMenuItem.Name = "saboresToolStripMenuItem";
            saboresToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F5;
            saboresToolStripMenuItem.Size = new Size(310, 24);
            saboresToolStripMenuItem.Text = "Sabores";
            // 
            // valoresToolStripMenuItem
            // 
            valoresToolStripMenuItem.Name = "valoresToolStripMenuItem";
            valoresToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F6;
            valoresToolStripMenuItem.Size = new Size(310, 24);
            valoresToolStripMenuItem.Text = "Valores";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F7;
            produtosToolStripMenuItem.Size = new Size(310, 24);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // configuraçãoToolStripMenuItem
            // 
            configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            configuraçãoToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F8;
            configuraçãoToolStripMenuItem.Size = new Size(310, 24);
            configuraçãoToolStripMenuItem.Text = "Configuração";
            // 
            // IngredientesCadastrados
            // 
            IngredientesCadastrados.Name = "IngredientesCadastrados";
            IngredientesCadastrados.ShortcutKeys = Keys.Shift | Keys.F9;
            IngredientesCadastrados.Size = new Size(310, 24);
            IngredientesCadastrados.Text = "Ingredientes Cadastrados";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.Delete;
            sairToolStripMenuItem.Size = new Size(310, 24);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // notifyIconSystemTray
            // 
            notifyIconSystemTray.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconSystemTray.BalloonTipText = "Aplicação continua executando na bandeja";
            notifyIconSystemTray.BalloonTipTitle = "Pizzaria do Zé";
            notifyIconSystemTray.ContextMenuStrip = contextMenuStripSystemTray;
            notifyIconSystemTray.Icon = (Icon)resources.GetObject("notifyIconSystemTray.Icon");
            notifyIconSystemTray.Text = "Pizzaria do Zé";
            notifyIconSystemTray.Visible = true;
            notifyIconSystemTray.MouseDoubleClick += notifyIconSystemTray_MouseDoubleClick_1;
            // 
            // contextMenuStripSystemTray
            // 
            contextMenuStripSystemTray.ImageScalingSize = new Size(20, 20);
            contextMenuStripSystemTray.Items.AddRange(new ToolStripItem[] { abrirAplicaçãoToolStripMenuItem, encerrarToolStripMenuItem, sobreToolStripMenuItem });
            contextMenuStripSystemTray.Name = "contextMenuStrip1";
            contextMenuStripSystemTray.Size = new Size(254, 76);
            // 
            // abrirAplicaçãoToolStripMenuItem
            // 
            abrirAplicaçãoToolStripMenuItem.Name = "abrirAplicaçãoToolStripMenuItem";
            abrirAplicaçãoToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F10;
            abrirAplicaçãoToolStripMenuItem.Size = new Size(253, 24);
            abrirAplicaçãoToolStripMenuItem.Text = "Abrir Aplicação";
            // 
            // encerrarToolStripMenuItem
            // 
            encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            encerrarToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F11;
            encerrarToolStripMenuItem.Size = new Size(253, 24);
            encerrarToolStripMenuItem.Text = "Encerrar";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F12;
            sobreToolStripMenuItem.Size = new Size(253, 24);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // ingCad
            // 
            ingCad.BackColor = SystemColors.ControlLightLight;
            ingCad.FlatStyle = FlatStyle.Flat;
            ingCad.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ingCad.Location = new Point(11, 260);
            ingCad.Name = "ingCad";
            ingCad.Size = new Size(275, 91);
            ingCad.TabIndex = 7;
            ingCad.TabStop = false;
            ingCad.Text = "Ingredientes Cadastrados";
            ingCad.UseVisualStyleBackColor = false;
            ingCad.Click += ingCad_Click;
            // 
            // buttonenderecos
            // 
            buttonenderecos.BackColor = SystemColors.ControlLightLight;
            buttonenderecos.FlatStyle = FlatStyle.Flat;
            buttonenderecos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonenderecos.Location = new Point(11, 168);
            buttonenderecos.Name = "buttonenderecos";
            buttonenderecos.Size = new Size(275, 85);
            buttonenderecos.TabIndex = 9;
            buttonenderecos.Text = "Endereços";
            buttonenderecos.UseVisualStyleBackColor = false;
            buttonenderecos.Click += buttonenderecos_Click;
            // 
            // Clientescad
            // 
            Clientescad.BackColor = SystemColors.ControlLightLight;
            Clientescad.FlatStyle = FlatStyle.Flat;
            Clientescad.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Clientescad.Location = new Point(11, 76);
            Clientescad.Name = "Clientescad";
            Clientescad.Size = new Size(275, 85);
            Clientescad.TabIndex = 11;
            Clientescad.Text = "Clientes Cadastrados";
            Clientescad.UseVisualStyleBackColor = false;
            Clientescad.Click += Clientescad_Click;
            // 
            // Funcionariocad
            // 
            Funcionariocad.BackColor = SystemColors.ControlLightLight;
            Funcionariocad.FlatStyle = FlatStyle.Flat;
            Funcionariocad.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Funcionariocad.Location = new Point(855, 76);
            Funcionariocad.Name = "Funcionariocad";
            Funcionariocad.Size = new Size(275, 89);
            Funcionariocad.TabIndex = 12;
            Funcionariocad.Text = "Funcionario Cadastrado";
            Funcionariocad.UseVisualStyleBackColor = false;
            Funcionariocad.Click += funcionariocad_Click;
            // 
            // saborescad
            // 
            saborescad.BackColor = SystemColors.ControlLightLight;
            saborescad.FlatStyle = FlatStyle.Flat;
            saborescad.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            saborescad.Location = new Point(855, 171);
            saborescad.Name = "saborescad";
            saborescad.Size = new Size(275, 89);
            saborescad.TabIndex = 13;
            saborescad.Text = "Sabores Cadastrados";
            saborescad.UseVisualStyleBackColor = false;
            saborescad.Click += saborescad_Click;
            // 
            // Valorescad
            // 
            Valorescad.BackColor = SystemColors.ControlLightLight;
            Valorescad.FlatStyle = FlatStyle.Flat;
            Valorescad.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Valorescad.Location = new Point(855, 267);
            Valorescad.Name = "Valorescad";
            Valorescad.Size = new Size(275, 89);
            Valorescad.TabIndex = 14;
            Valorescad.Text = "Valores Cadastrados";
            Valorescad.UseVisualStyleBackColor = false;
            Valorescad.Click += Valorescad_Click;
            // 
            // ProdCad
            // 
            ProdCad.BackColor = SystemColors.ControlLightLight;
            ProdCad.FlatStyle = FlatStyle.Flat;
            ProdCad.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ProdCad.Location = new Point(856, 361);
            ProdCad.Name = "ProdCad";
            ProdCad.Size = new Size(275, 89);
            ProdCad.TabIndex = 15;
            ProdCad.Text = "Produtos Cadastrados";
            ProdCad.UseVisualStyleBackColor = false;
            ProdCad.Click += ProdCad_Click;
            // 
            // PaginaInicialDoZe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1166, 499);
            ContextMenuStrip = contextMenuStripPrincipal;
            Controls.Add(ProdCad);
            Controls.Add(Valorescad);
            Controls.Add(saborescad);
            Controls.Add(Funcionariocad);
            Controls.Add(Clientescad);
            Controls.Add(buttonenderecos);
            Controls.Add(ingCad);
            Controls.Add(buttonConfiguracao);
            Controls.Add(CadastroProdutos);
            Controls.Add(CadastroValores);
            Controls.Add(SABORES1);
            Controls.Add(INGREDIENTES1);
            Controls.Add(CLIENTES1);
            Controls.Add(FUNCIONÁRIOS1);
            Controls.Add(PIZZARIADOZE);
            Cursor = Cursors.IBeam;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "PaginaInicialDoZe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pizzaria Do Ze";
            FormClosing += PaginaInicialDoZe_FormClosing_1;
            Load += PaginaInicialDoZe_Load;
            Resize += PaginaInicialDoZe_Resize;
            contextMenuStripPrincipal.ResumeLayout(false);
            contextMenuStripSystemTray.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PIZZARIADOZE;
        private Button FUNCIONÁRIOS1;
        private Button CLIENTES1;
        private Button INGREDIENTES1;
        private Button SABORES1;
        private Button CadastroValores;
        private Button CadastroProdutos;
        private Button buttonConfiguracao;
        private ContextMenuStrip contextMenuStripPrincipal;
        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem ingredienteToolStripMenuItem;
        private ToolStripMenuItem saboresToolStripMenuItem;
        private ToolStripMenuItem valoresToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem configuraçãoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private NotifyIcon notifyIconSystemTray;
        private ContextMenuStrip contextMenuStripSystemTray;
        private ToolStripMenuItem abrirAplicaçãoToolStripMenuItem;
        private ToolStripMenuItem encerrarToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private Button ingCad;
        private ToolStripMenuItem IngredientesCadastrados;
        private Button buttonenderecos;
        private Button Clientescad;
        private Button Funcionariocad;
        private Button saborescad;
        private Button Valorescad;
        private Button ProdCad;
    }
}