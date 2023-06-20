using PizzariaDaBiblioteca.DAO;
using ProjetoDevSistemas2023.DAO;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoDevSistemas2023
{
    public partial class sabores : Form
    {
        private IngredientesDAO ingredientesDAO;
        private SaborDAO saborDAO;
        // pega os dados do banco de dados
        string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        public sabores()
        {
            InitializeComponent();
            this.ControlBox = false; //REMOVE BOTÕES DE MINIZAR E FECHAR
            UserControl12.buttonFechar.Click += buttonFechar_Click;
            UserControl12.buttonSalvar.Click += buttonSalvar_Click;
            UserControl12.buttonEditar.Click += buttonEditar_Click;
            UserControl12.buttonExcluir.Click += buttonExcluir_Click;
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
            textBoxNome.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            textBoxNome.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            textBoxID.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            textBoxID.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            this.KeyPreview = true; // permite que o formulário receba eventos de teclado
            this.KeyDown += new KeyEventHandler(sabores_KeyDown); // associa o evento ao formulário
            // cria a instancia da classe da model
            saborDAO = new SaborDAO(provider, strConnection);
            ingredientesDAO = new IngredientesDAO(provider, strConnection);

        }

        private void CarregaIngredientesCheckedListBox()
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = ingredientesDAO.Buscar(ingrediente);
                // carrega os dados, como objeto, no checkedListBox
                checkedListBoxIngredientes.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                    checkedListBoxIngredientes.Items.Add(new Ingrediente(int.Parse(row["ID"].ToString()), row["Nome"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSalvar_Click(object? sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor
            {
                Id = 0,
                Descricao = textBoxNome.Text,
                Foto = Funcoes.ConverteImagemParaByteArray(pictureBoxImagem.Image),
                Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategoria.Text),
                Tipo = (char)(EnumSaborTipo)Enum.Parse(typeof(EnumSaborTipo), listBoxTipo.Text),
                SaborIngredientes = checkedListBoxIngredientes.CheckedItems.OfType<Ingrediente>().ToList(),
            };
            try
            {
                // chama o método para inserir da camada model
                saborDAO.Inserir(sabor);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um sabor!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor
            {
                Id = int.Parse(textBoxID.Text),
            };
            try
            {
                // chama o método para inserir da camada model
                saborDAO.Excluir(sabor);
                MessageBox.Show("Dados excluidos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor
            {
                Id = id,

            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = saborDAO.Buscar(sabor);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxID.Text = row[0].ToString();
                    textBoxNome.Text = row[1].ToString();
                    pictureBoxImagem.Image = Funcoes.ConverteByteArrayParaImagem((byte[])row[2]);
                    listBoxCategoria.Text = EnumExtensions.GetDescription((EnumSaborCategoria)char.Parse(row[3].ToString()));
                    listBoxTipo.Text = EnumExtensions.GetDescription((EnumSaborTipo)char.Parse(row[4].ToString()));
                    // busca e seleciona os itens do sabor
                    DataTable linhasIngredientes = saborDAO.BuscarItensSabor(sabor);
                    foreach (DataRow dr in linhasIngredientes.Rows)
                    {
                        for (int i = 0; i < checkedListBoxIngredientes.Items.Count; i++)
                        {
                            if (dr[1].ToString() == ((Ingrediente)checkedListBoxIngredientes.Items[i]).Nome.ToString())
                            {
                                checkedListBoxIngredientes.SetItemChecked(i, true);
                            }
                        }
                    }
                }
                textBoxNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um sabor!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor
            {
                Id = int.Parse(textBoxID.Text),
                Descricao = textBoxNome.Text,
                Foto = Funcoes.ConverteImagemParaByteArray(pictureBoxImagem.Image),
                Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategoria.Text),
                Tipo = (char)(EnumSaborTipo)Enum.Parse(typeof(EnumSaborTipo), listBoxTipo.Text),
                SaborIngredientes = checkedListBoxIngredientes.CheckedItems.OfType<Ingrediente>().ToList(),
            };
            try
            {
                // chama o método para inserir da camada model
                saborDAO.Editar(sabor);
                MessageBox.Show("Dados editados com sucesso!");
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
        private void sabores_Load(object sender, EventArgs e)
        {

        }
        private void userControl12_Load(object sender, EventArgs e)
        {

        }


        private void sabores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // fecha a tela atual
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void CarregaEnumListBox()
        {
            //popular listBoxCategoria
            listBoxCategoria.Items.Clear();
            listBoxCategoria.DataSource = Enum.GetValues(typeof(EnumSaborCategoria));
            //popular listBoxTipo
            listBoxTipo.Items.Clear();
            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumSaborTipo));
        }

        private void pictureBoxImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogImagem = new()
            {
                Title = "Imagem do produto",
                Filter = "Images (*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.)|*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.icon;*.JFIF"
            };
            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                //pega a imagem escolhida e adiciona na tela
                pictureBoxImagem.Image = Image.FromFile(openFileDialogImagem.FileName);
                //redimensiona a imagem
                pictureBoxImagem.Image = (Image)(new Bitmap(pictureBoxImagem.Image, new Size(130, 98)));
                //ajusta a visualização no tamanho do pictureBoxImagem na tela
                pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}