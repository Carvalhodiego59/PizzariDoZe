using PizzariaDaBiblioteca.DAO;
using System.Configuration;
using System.Data.SqlClient;

namespace ProjetoDevSistemas2023
{
    public partial class valores : Form
    {
        private ValorDAO valorDAO;

        // pega os dados do banco de dados
        string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        string strConnection =
        ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

        public valores()
        {
            InitializeComponent();
            this.ControlBox = false; //REMOVE BOTÕES DE MINIZAR E FECHAR
            userControl11.buttonFechar.Click += buttonFechar_Click; //BOTAO SAIR
            userControl11.buttonSalvar.Click += buttonSalvar_Click;
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
            textBoxVAB.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            textBoxVAB.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            textBoxVAL.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            textBoxVAL.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            textBoxID.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            textBoxID.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            this.KeyPreview = true; // permite que o formulário receba eventos de teclado
            this.KeyDown += new KeyEventHandler(valores_KeyDown); // associa o evento ao formulário
            // cria a instancia da classe da model
            valorDAO = new ValorDAO(provider, strConnection);

        }
        private void buttonSalvar_Click(object? sender, EventArgs e)
        {

            //Instância e Preenche o objeto com os dados da view
            var valor = new Valor
            {
                Id = 0,
                Tamanho = (char)(EnumValorTamanho)Enum.Parse(typeof(EnumValorTamanho), listBoxTamanho.Text),
                Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategoria.Text),
                ValorPizza = decimal.Parse(maskedTextBoxVal.Text),
                ValorBorda = decimal.Parse(maskedTextBoxVAB.Text),
            };
            try
            {
                // chama o método para inserir da camada model
                valorDAO.Inserir(valor);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CarregaEnumListBox()
        {
            //popular listBoxTipo
            listBoxTamanho.Items.Clear();
            listBoxTamanho.DataSource = Enum.GetValues(typeof(EnumValorTamanho));
            //popular listBoxCategoria
            listBoxCategoria.Items.Clear();
            listBoxCategoria.DataSource = Enum.GetValues(typeof(EnumSaborCategoria));
        }
        private void valores_Load(object sender, EventArgs e)
        {

        }
        public void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void valores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // fecha a tela atual
            }
        }

        private void textBoxID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void textBoxVAL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void textBoxVAB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void maskedTextValor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
