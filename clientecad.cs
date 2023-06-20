using MySqlX.XDevAPI;
using PizzariaDaBiblioteca.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDevSistemas2023
{
    public partial class clientecad : Form
    {
        private ClienteDAO clienteDAO;
        // pega os dados do banco de dados
        string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

        public clientecad()
        {
            InitializeComponent();

            // cria a instancia da classe da model
            clienteDAO = new ClienteDAO(provider, strConnection);

            AtualizarTela();
        }

        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewDados.Columns.Clear();
                dataGridViewDados.AutoGenerateColumns = true;
                dataGridViewDados.DataSource = linhas;
                dataGridViewDados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void dataGridViewDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
