using PizzariaDaBiblioteca.DAO;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoDevSistemas2023
{
    public partial class produtos : Form
    {
        private ProdutoDAO produtoDAO;
        // pega os dados do banco de dados
        string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

        public produtos()
        {
            InitializeComponent();
            this.ControlBox = false; //REMOVE BOTÕES DE MINIZAR E FECHAR
            userControl11.buttonSalvar.Click += buttonSalvar_Click;
            userControl11.buttonFechar.Click += buttonFechar_Click;//BOTAO SAIR
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
            textBoxIDPROD.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            textBoxIDPROD.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            textBoxNPROD.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            textBoxNPROD.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            textBoxVALPROD.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            textBoxVALPROD.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            this.KeyPreview = true; // permite que o formulário receba eventos de teclado
            this.KeyDown += new KeyEventHandler(produtos_KeyDown); // associa o evento ao formulário

            // cria a instancia da classe da model
            produtoDAO = new ProdutoDAO(provider, strConnection);
        }

        private void buttonSalvar_Click(object? sender, EventArgs e)
        {

            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                Id = 0,
                Descricao = textBoxNPROD.Text,
                Valor = decimal.Parse(maskedTextBoxVal.Text),
                Tipo = (char)(EnumProdutoTipo)Enum.Parse(typeof(EnumProdutoTipo), listBoxTipo.Text),
                ML = listBoxML.Text,
            };
            try
            {
                // chama o método para inserir da camada model
                produtoDAO.Inserir(produto);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void produtos_Load(object sender, EventArgs e)
        {

        }
        public void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.buttonFechar.Click += ButtonFechar_Click;
        }

        private void ButtonFechar_Click(object? sender, EventArgs e)
        {
            Close();
        }


        private void textBoxIDPROD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void textBoxNPROD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void textBoxVALPROD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void produtos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // fecha a tela atual
            }
        }

        private void CarregaEnumListBox()
        {
            //popular listBoxTipo
            listBoxTipo.Items.Clear();
            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumProdutoTipo));
        }
    }
}
