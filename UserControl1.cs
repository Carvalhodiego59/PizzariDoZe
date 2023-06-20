namespace ProjetoDevSistemas2023
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
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
        }

        private void buttonSalvar_Click(object sender, EventArgs e)//salvar
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)//editar
        {

        }

        private void buttonExcluir_Click(object sender, EventArgs e)//excluir
        {

        }

        private void ButtonFechar_Click(object? sender, EventArgs e)//fechar
        {

        }

        private void buttonSalvar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                buttonSalvar.PerformClick(); // executa a ação esperada para o botão
            }
        }

        private void buttonEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                buttonEditar.PerformClick(); // executa a ação esperada para o botão
            }
        }

        private void buttonExcluir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                buttonExcluir.PerformClick(); // executa a ação esperada para o botão
            }
        }

        private void buttonFechar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede que o caractere "enter" apareça no campo
                buttonFechar.PerformClick(); // executa a ação esperada para o botão
            }
        }
    }
}
