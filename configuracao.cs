using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Math.EC.ECCurve;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace ProjetoDevSistemas2023
{
    public partial class configuracao : Form
    {
        public configuracao()
        {
            InitializeComponent();
            //seleciona no comboBox o idioma/cultura atual
            CBidiomaregiao.SelectedItem = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
            CBidiomaregiao.SelectedItem = ConfigurationManager.AppSettings.Get("Cultura");

            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            checkBoxidiomaregiao.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            checkBoxidiomaregiao.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            // busca os dados com nome BD
            ConnectionStringSettings connectionStringSettings =
            ConfigurationManager.ConnectionStrings["BD"];
            // obtém o providerName e atualiza em tela
            comboBoxProvider.Text = connectionStringSettings.ProviderName;
            // obtém a connectionString e atualiza em tela
            textBoxStringDeConexao.Text = connectionStringSettings.ConnectionString;

        }

        private void configuracao_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalvarIdioma_Click(object sender, EventArgs e)
        {
            //abre o arquivo local como leitura/escrita e salva as alterações em ProjetoPastelariaDoZe_2023.dll.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", CBidiomaregiao.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            Close();
            _ = MessageBox.Show("Idioma/região alterada com sucesso! Reinicie a aplicação para aplicar o novo Idioma/região!");
            if (checkBoxidiomaregiao.Checked)
            {
                Application.Restart();
                Environment.Exit(0);
            }


        }

        private void buttonSalvarIdioma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                buttonSalvarIdioma.PerformClick(); // executa a ação esperada para o botão
            }
        }

        private void CBidiomaregiao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }

        private void checkBoxidiomaregiao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                this.SelectNextControl((Control)sender, true, true, true, true); // passa o foco para o próximo controle
            }
        }
        public static void ValidaConexaoDB()
        {
            DbProviderFactory factory;
            try
            {
                factory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["BD"].ProviderName);
                using var conexao = factory.CreateConnection();
                conexao!.ConnectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
                using var comando = factory.CreateCommand();
                comando!.Connection = conexao;
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                new configuracao().ShowDialog();
                ValidaConexaoDB();
            }
        }

        private void buttonsalvardados_Click(object sender, EventArgs e)
        {
            //abre o arquivo local como leitura/escrita - ControleEstoqueDoZe.exe.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //altera os valores de provider e da connectionStrings com nome BD
            config.ConnectionStrings.ConnectionStrings["BD"].ProviderName = comboBoxProvider.Text;
            config.ConnectionStrings.ConnectionStrings["BD"].ConnectionString = textBoxStringDeConexao.Text;
            //salva as alterações
            config.Save(ConfigurationSaveMode.Modified, true);
            //recarrega os dados da seção especificada
            ConfigurationManager.RefreshSection("connectionStrings");
            //fecha a tela
            Close();
            //dispara msg para usuário
            _ = MessageBox.Show("Dados alterados com sucesso!");
        }
    }
}
