using MySqlX.XDevAPI;
using PizzariaDaBiblioteca.DAO;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoDevSistemas2023
{
    public partial class clientes : Form
    {
        private readonly EnderecoDAO enderecoDAO;
        private readonly ClienteDAO clienteDAO;

        public clientes()
        {


            InitializeComponent();
            this.ControlBox = false; //REMOVE BOTÕES DE MINIZAR E FECHAR

            userControl12.buttonSalvar.Click += buttonSalvar_Click;
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
            NomeCliente.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            NomeCliente.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            CPFCliente.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            CPFCliente.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            maskedTextBoxCPF.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            maskedTextBoxCPF.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            maskedTextBoxTELEFONE.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            maskedTextBoxTELEFONE.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            maskedTextBoxCEP.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            maskedTextBoxCEP.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            IDCliente.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            IDCliente.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            EMAILDOCLIENTE.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            EMAILDOCLIENTE.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            TELEFONEDOCLIENTE.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            TELEFONEDOCLIENTE.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            PAISEND.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            PAISEND.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            CIDADEEND.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            CIDADEEND.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            BAIROEND.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            BAIROEND.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            COMPLEMENTODACASA.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            COMPLEMENTODACASA.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            NUMERODACASA.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            NUMERODACASA.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            LOGRADOUROEND.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            LOGRADOUROEND.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            CEPENDEREÇO.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            CEPENDEREÇO.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            ENDEREÇODOID.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            ENDEREÇODOID.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            UFEND.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            UFEND.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            this.KeyPreview = true; // permite que o formulário receba eventos de teclado
            this.KeyDown += new KeyEventHandler(clientes_KeyDown); // associa o evento ao formulário
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            maskedTextBoxCEP.Leave += maskedTextBoxCEP_Leave;


            // cria a instancia da classe da model
            clienteDAO = new ClienteDAO(provider, strConnection);

        }
        private void maskedTextBoxCEP_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxCEP.Text.Trim().Length <= 0)
            {
                return;
            }
            var endereco = new Endereco
            {
                Cep = maskedTextBoxCEP.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta os dados na tela
                ENDEREÇODOID.Text = "";
                maskedTextBoxCEP.Text = "";
                LOGRADOUROEND.Text = "";
                BAIROEND.Text = "";
                CIDADEEND.Text = "";
                UFEND.Text = "";
                PAISEND.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    ENDEREÇODOID.Text = row["id"].ToString(); ;
                    maskedTextBoxCEP.Text = row["cep"].ToString(); ;
                    LOGRADOUROEND.Text = row["logradouro"].ToString(); ;
                    BAIROEND.Text = row["bairro"].ToString(); ;
                    CIDADEEND.Text = row["cidade"].ToString(); ;
                    UFEND.Text = row["uf"].ToString(); ;
                    PAISEND.Text = row["pais"].ToString(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (IDCliente.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                Id = 0,
                Nome = NomeCliente.Text,
                Cpf = maskedTextBoxCPF.Text,
                Telefone = maskedTextBoxTELEFONE.Text,
                Email = EMAILDOCLIENTE.Text,
                EnderecoId = int.Parse(IDCliente.Text),
                Numero = NUMERODACASA.Text,
                Complemento = COMPLEMENTODACASA.Text,
            };
            try
            {
                // chama o método da model para inserir e capturar o ID do cliente
                int IdClienteGerado = clienteDAO.Inserir(cliente);
                MessageBox.Show("Dados inseridos com sucesso! " + IdClienteGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void IDCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void maskedTextBoxCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void NomeCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void ENDEREÇODOID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void maskedTextBoxCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void LOGRADOUROEND_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void NUMERODACASA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void COMPLEMENTODACASA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void BAIROEND_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void CIDADEEND_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void UFEND_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void PAISEND_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void maskedTextBoxTELEFONE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void EMAILDOCLIENTE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void clientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // fecha a tela atual
            }
        }

    }
}