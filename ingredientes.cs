#nullable disable
using PizzariaDaBiblioteca.DAO;
using ProjetoDevSistemas2023.DAO;
using System.Configuration;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoDevSistemas2023
{
    public partial class ingredientes : Form
    {
        private readonly IngredientesDAO dao;
        public ingredientes()
        {
            InitializeComponent();
            this.ControlBox = false; //REMOVE BOTÕES DE MINIZAR E FECHAR
            userControl12.buttonFechar.Click += buttonFechar_Click;
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
            textBoxNOMEING.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            textBoxNOMEING.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            textBoxIDING.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            textBoxIDING.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            this.KeyPreview = true; // permite que o formulário receba eventos de teclado
            this.KeyDown += new KeyEventHandler(ingredientes_KeyDown); // associa o evento ao formulário

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string stringConexao = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            dao = new IngredientesDAO(provider, stringConexao);
            userControl12.buttonSalvar.Click += buttonSalvar_Click;
        }
        public void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void ingredientes_Load(object sender, EventArgs e)
        {

        }

        private void textBoxIDING_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void textBoxNOMEING_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void ingredientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // fecha a tela atual
            }
        }
        private void buttonSalvar_Click(object? sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente
            {
                Id = 0,
                Nome = textBoxNOMEING.Text,

            };
            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(ingrediente);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void userControl12_Load(object sender, EventArgs e)
        {

        }

        private void textBoxIDING_TextChanged(object sender, EventArgs e)
        {
            int maxLength = 4; // Limite máximo de caracteres permitidos

            if (textBoxIDING.Text.Length > maxLength)
            {
                textBoxIDING.Text = textBoxIDING.Text.Substring(0, maxLength); // Limita o texto aos caracteres permitidos
            }
        }

        private void textBoxNOMEING_TextChanged(object sender, EventArgs e)
        {
            int maxLength = 10; // Limite máximo de caracteres permitidos

            if (textBoxNOMEING.Text.Length > maxLength)
            {
                textBoxNOMEING.Text = textBoxNOMEING.Text.Substring(0, maxLength); // Limita o texto aos caracteres permitidos
            }
        }
    }
}