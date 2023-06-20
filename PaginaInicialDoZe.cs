namespace ProjetoDevSistemas2023
{
    public partial class PaginaInicialDoZe : Form
    {
        public PaginaInicialDoZe()
        {
            InitializeComponent();
            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo
            // resources
            Funcoes.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser
            // automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            FUNCIONÁRIOS1.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            FUNCIONÁRIOS1.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            CLIENTES1.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            CLIENTES1.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            INGREDIENTES1.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            INGREDIENTES1.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            SABORES1.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            SABORES1.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            ingCad.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            ingCad.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            CadastroValores.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            CadastroValores.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            CadastroProdutos.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            CadastroProdutos.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            buttonConfiguracao.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            buttonConfiguracao.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            funcionárioToolStripMenuItem.Click += new EventHandler(buttonFuncionarios_Click);
            clienteToolStripMenuItem.Click += new EventHandler(buttonClientes_Click);
            ingredienteToolStripMenuItem.Click += new EventHandler(buttonIngredientes_Click);
            saboresToolStripMenuItem.Click += new EventHandler(buttonSabores_Click);
            valoresToolStripMenuItem.Click += new EventHandler(CadastroValores_Click);
            produtosToolStripMenuItem.Click += new EventHandler(CadastroProdutos_Click);
            configuraçãoToolStripMenuItem.Click += new EventHandler(buttonconfig_Click);
            sairToolStripMenuItem.Click += new EventHandler(sairToolStripMenuItem_Click);


            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            Funcoes.AjustaResourcesItem(contextMenuStripPrincipal);
        }

        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {
            funcionarios funcionarios = new funcionarios();
            funcionarios.StartPosition = FormStartPosition.CenterScreen;
            funcionarios.Show();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            clientes clientes = new clientes();
            clientes.StartPosition = FormStartPosition.CenterScreen;
            clientes.Show();
        }

        private void buttonIngredientes_Click(object sender, EventArgs e)
        {
            ingredientes ingredientes = new ingredientes();
            ingredientes.StartPosition = FormStartPosition.CenterScreen;
            ingredientes.Show();
        }

        private void buttonSabores_Click(object sender, EventArgs e)
        {
            sabores sabores = new sabores();
            sabores.StartPosition = FormStartPosition.CenterScreen;
            sabores.Show();
        }
        private void CadastroValores_Click(object sender, EventArgs e)
        {
            valores valores = new valores();
            valores.StartPosition = FormStartPosition.CenterScreen;
            valores.Show();
        }

        private void CadastroProdutos_Click(object sender, EventArgs e)
        {
            produtos produtos = new produtos();
            produtos.StartPosition = FormStartPosition.CenterScreen;
            produtos.Show();
        }
        private void ingCad_Click(object sender, EventArgs e)
        {
            ingredientescadastrados ingredientescadastrados = new ingredientescadastrados();
            ingredientescadastrados.StartPosition = FormStartPosition.CenterScreen;
            ingredientescadastrados.Show();
        }
        private void buttonenderecos_Click(object sender, EventArgs e)
        {
            endereço endereço = new endereço();
            endereço.StartPosition = FormStartPosition.CenterScreen;
            endereço.Show();
        }


        private void PIZZARIADOZE_Click(object sender, EventArgs e)
        {

        }

        private void PaginaInicialDoZe_Load(object sender, EventArgs e)
        {

        }

        private void buttonconfig_Click(object sender, EventArgs e)
        {
            configuracao configuracao = new configuracao();
            configuracao.StartPosition = FormStartPosition.CenterScreen;
            configuracao.Show();
        }

        private void PaginaInicialDoZe_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconSystemTray.Visible = true;
                notifyIconSystemTray.ShowBalloonTip(1000);

            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconSystemTray.Visible = false;
            }
        }

        private void notifyIconSystemTray_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }

        private void PaginaInicialDoZe_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            // Verifica se o fechamento foi requisitado pelo usuário
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Cancela o fechamento padrão da janela
                e.Cancel = true;

                // Mostra uma mensagem de confirmação
                DialogResult result = MessageBox.Show("Tem certeza que quer fechar o programa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Se o usuário confirmar, fecha a janela
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                    Application.Exit();
                }
            }
        }
        private void FUNCIONÁRIOS1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                FUNCIONÁRIOS1.PerformClick(); // executa a ação esperada para o botão
            }
        }

        private void SABORES1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                SABORES1.PerformClick(); // executa a ação esperada para o botão
            }
        }

        private void CLIENTES1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                CLIENTES1.PerformClick(); // executa a ação esperada para o botão
            }
        }

        private void CadastroValores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                CadastroValores.PerformClick(); // executa a ação esperada para o botão
            }
        }

        private void INGREDIENTES1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                INGREDIENTES1.PerformClick(); // executa a ação esperada para o botão
            }
        }

        private void CadastroProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                CadastroProdutos.PerformClick(); // executa a ação esperada para o botão
            }
        }

        private void buttonConfiguracao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                buttonConfiguracao.PerformClick(); // executa a ação esperada para o botão
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Clientescad_Click(object sender, EventArgs e)
        {
            clientecad clientecad = new clientecad();
            clientecad.StartPosition = FormStartPosition.CenterScreen;
            clientecad.Show();
        }

        private void funcionariocad_Click(object sender, EventArgs e)
        {
            funcionariocad funcionariocad = new funcionariocad();
            funcionariocad.StartPosition = FormStartPosition.CenterScreen;
            funcionariocad.Show();
        }

        private void saborescad_Click(object sender, EventArgs e)
        {
            Saborescad Saborescad = new Saborescad();
            Saborescad.StartPosition = FormStartPosition.CenterScreen;
            Saborescad.Show();
        }

        private void Valorescad_Click(object sender, EventArgs e)
        {
            ValorCad ValorCad = new ValorCad();
            ValorCad.StartPosition = FormStartPosition.CenterScreen;
            ValorCad.Show();
        }

        private void ProdCad_Click(object sender, EventArgs e)
        {
            ProdutosCad ProdutosCad = new ProdutosCad();
            ProdutosCad.StartPosition = FormStartPosition.CenterScreen;
            ProdutosCad.Show();
        }


    }
}