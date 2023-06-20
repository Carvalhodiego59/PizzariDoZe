using System.Drawing.Drawing2D;
using PizzariaDaBiblioteca.DAO;
using System.Configuration;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.ComponentModel;
using System.Reflection;

namespace ProjetoDevSistemas2023
{

    public partial class funcionarios : Form
    {
        private readonly EnderecoDAO enderecoDAO;
        private readonly FuncionarioDAO funcionarioDAO;

        public funcionarios()
        {
            InitializeComponent();
            this.ControlBox = false; //REMOVE BOTÕES DE MINIZAR E FECHAR
            userControl12.buttonSalvar.Click += buttonSalvar_Click;
            userControl12.buttonFechar.Click += buttonFechar_Click; //BOTAO SAIR
            userControl12.buttonEditar.Click += buttonEditar_Click;
            userControl12.buttonExcluir.Click += buttonExcluir_Click;
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
            RESENHARES.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            RESENHARES.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            SENHARES.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            SENHARES.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            maskedTextBoxcpf.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            maskedTextBoxcpf.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            maskedTextBoxcep.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            maskedTextBoxcep.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            maskedTextBoxtelefone.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            maskedTextBoxtelefone.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            CMFUNCRES.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            CMFUNCRES.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            OBSRES.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            OBSRES.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            NOMEFUNCRES.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            NOMEFUNCRES.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            MAFUNCRES.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            MAFUNCRES.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            CPFFUNCRES.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            CPFFUNCRES.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            IDFUNCRES.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            IDFUNCRES.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            EMAILFUNENDRES.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            EMAILFUNENDRES.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            TELEFONEENDRESFUN.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            TELEFONEENDRESFUN.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            PENDRESFUN.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            PENDRESFUN.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            CIDFUNENDRES.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            CIDFUNENDRES.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            BAIRROFUNENDRES.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            BAIRROFUNENDRES.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            COMPFUNENDRES.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            COMPFUNENDRES.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            NFUNENRES.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            NFUNENRES.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            LOGFUNCENDRES.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            LOGFUNCENDRES.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            CEPFUNCENDRES.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            CEPFUNCENDRES.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            IDFUNCRESEND.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            IDFUNCRESEND.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            UFFUNENDRES.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            UFFUNENDRES.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            this.KeyPreview = true; // permite que o formulário receba eventos de teclado
            this.KeyDown += new KeyEventHandler(funcionarios_KeyDown); // associa o evento ao formulário

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            maskedTextBoxcep.Leave += maskedTextBoxcep_Leave;

            // cria a instancia da classe da model
            funcionarioDAO = new FuncionarioDAO(provider, strConnection);

        }

        private void maskedTextBoxcep_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxcep.Text.Trim().Length <= 0)
            {
                return;
            }
            var endereco = new Endereco
            {
                Cep = maskedTextBoxcep.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta os dados na tela
                IDFUNCRESEND.Text = "";
                maskedTextBoxcep.Text = "";
                LOGFUNCENDRES.Text = "";
                BAIRROFUNENDRES.Text = "";
                CIDFUNENDRES.Text = "";
                UFFUNENDRES.Text = "";
                PENDRESFUN.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    IDFUNCRESEND.Text = row["id"].ToString(); ;
                    maskedTextBoxcep.Text = row["cep"].ToString(); ;
                    LOGFUNCENDRES.Text = row["logradouro"].ToString(); ;
                    BAIRROFUNENDRES.Text = row["bairro"].ToString(); ;
                    CIDFUNENDRES.Text = row["cidade"].ToString(); ;
                    UFFUNENDRES.Text = row["uf"].ToString(); ;
                    PENDRESFUN.Text = row["pais"].ToString(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonSalvar_Click(object? sender, EventArgs e)
        {
            if (IDFUNCRES.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                Id = 0,
                Nome = NOMEFUNCRES.Text,
                Cpf = maskedTextBoxcpf.Text,
                Matricula = MAFUNCRES.Text,
                Senha = Funcoes.Sha256Hash(SENHARES.Text),
                Grupo = (radioButtonGrupoAdmin.Checked) ? '1' : (radioButtonGrupoAtendente.Checked) ? '2' : '3',
                Motorista = maskedTextBoxcarteiramotorista.Text,
                Validade = dateTimePickerValidade.Value,
                Observacao = OBSRES.Text,
                Telefone = maskedTextBoxtelefone.Text,
                Email = EMAILFUNENDRES.Text,
                EnderecoId = int.Parse(IDFUNCRES.Text),
                Numero = NFUNENRES.Text,
                Complemento = COMPFUNENDRES.Text,
            };
            try
            {
                // chama o método da model para inserir e capturar o ID do cliente
                int IdFuncionarioGerado = funcionarioDAO.Inserir(funcionario);
                MessageBox.Show("Dados inseridos com sucesso! " + IdFuncionarioGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (IDFUNC.Text.Length <= 0 || IDFUNC.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um funcionário e endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                Id = int.Parse(IDFUNC.Text),
                Nome = NOMEFUNC.Text,
                Cpf = maskedTextBoxcpf.Text,
                Matricula = MATRICULAFUNC.Text,
                Senha = Funcoes.Sha256Hash(SENHA.Text),
                Grupo = (radioButtonGrupoAdmin.Checked) ? '1' : (radioButtonGrupoAtendente.Checked) ? '2' : '3',
                Motorista = maskedTextBoxcarteiramotorista.Text,
                Validade = dateTimePickerValidade.Value,
                Observacao = OBSERVAÇAOFUNC.Text,
                Telefone = maskedTextBoxtelefone.Text,
                Email = EMAILFUNENDRES.Text,
                EnderecoId = int.Parse(IDFUNC.Text),
                Numero = NUMEROFUNCEND.Text,
                Complemento = COMPLEMENTOFUNCEND.Text,
            };
            try
            {
                // chama o método da model para editar
                funcionarioDAO.Editar(funcionario);
                MessageBox.Show("Dados editados com sucesso! " + IDFUNC.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (IDFUNC.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um funcionário!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                Id = int.Parse(IDFUNC.Text),
            };
            try
            {
                // chama o método da model para excluir
                funcionarioDAO.Excluir(funcionario);
                MessageBox.Show("Dados excluidos com sucesso! " + IDFUNC.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                Id = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = funcionarioDAO.Buscar(funcionario);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    IDFUNC.Text = row[0].ToString();
                    NOMEFUNC.Text = row[1].ToString();
                    maskedTextBoxcpf.Text = row[2].ToString();
                    MATRICULAFUNC.Text = row[3].ToString();
                    SENHA.Text = row[4].ToString();
                    if (row[5].ToString().Equals("1"))
                    {
                        radioButtonGrupoAdmin.Checked = true;
                    }
                    else if (row[5].ToString().Equals("2"))
                    {
                        radioButtonGrupoAtendente.Checked = true;
                    }
                    else
                    {
                        radioButtonEntregador.Checked = true;
                    }
                    maskedTextBoxcarteiramotorista.Text = row[6].ToString();
                    dateTimePickerValidade.Text = row[7].ToString();
                    OBSERVAÇAOFUNC.Text = row[8].ToString();
                    maskedTextBoxtelefone.Text = row[9].ToString();
                    EMAILFUNENDRES.Text = row[10].ToString();
                    IDFUNCRESEND.Text = row[11].ToString();
                    maskedTextBoxcep.Text = row[12].ToString();
                    LOGFUNCENDRES.Text = row[13].ToString();
                    BAIRROFUNENDRES.Text = row[14].ToString();
                    CIDFUNENDRES.Text = row[16].ToString();
                    UFFUNENDRES.Text = row[18].ToString();
                    PENDRESFUN.Text = row[20].ToString();
                    NUMEROFUNCEND.Text = row[21].ToString();
                    COMPLEMENTOFUNCEND.Text = row[22].ToString();
                }
                NOMEFUNC.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void funcionarios_Load(object sender, EventArgs e)
        {

        }
        public void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void userControl12_Load(object sender, EventArgs e)
        {

        }

        private void IDFUNCRES_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void maskedTextBoxcpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void MAFUNCRES_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void NOMEFUNCRES_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void OBSRES_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void CMFUNCRES_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void VALIDADEFUNCRES_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void SENHARES_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void RESENHARES_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void IDFUNCRESEND_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void maskedTextBoxcep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void LOGFUNCENDRES_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void NFUNENRES_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void COMPFUNENDRES_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void BAIRROFUNENDRES_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void CIDFUNENDRES_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void UFFUNENDRES_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void PENDRESFUN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void maskedTextBoxtelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void EMAILFUNENDRES_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void funcionarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // fecha a tela atual
            }
        }

        private void CADASTROFUNC_Click(object sender, EventArgs e)
        {

        }
    }
}