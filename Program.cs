using System.Configuration;
using System.Data.Common;
using System.Globalization;

namespace ProjetoDevSistemas2023
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // No .NET 2.1 ou posterior os provedores não são mais registrados automaticamente no DbProviderFactories

            // Após instalar os pacotes via NuGet, realizar o registro manualmente no DbProviderFactories

            DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance); 
            DbProviderFactories.RegisterFactory("MySql.Data.MySqlClient", MySql.Data.MySqlClient.MySqlClientFactory.Instance);

            string? auxIdiomaRegiao = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
            //ajusta o idioma/região
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo(auxIdiomaRegiao!);
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo(auxIdiomaRegiao!);



            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new PaginaInicialDoZe());
        }
    }
}