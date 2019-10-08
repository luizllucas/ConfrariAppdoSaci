using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PCLExt.FileStorage.Folders;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ConfrariApp
{
    public partial class App : Application
    {
        public SQLite.SQLiteConnection conexao { get; private set; } //conexao com o banco de dados

        public App()
        {

            var pasta = new LocalRootFolder();

            ////crio o arquivo do banco (se ele não existir)
            ////Se ele existir, só quero que abra

            var arquivo = pasta.CreateFile("confrariapp.db", PCLExt.FileStorage.CreationCollisionOption.OpenIfExists);

            ////faço a "conexao"
            conexao = new SQLite.SQLiteConnection(arquivo.Path);

            ////criar a tabela, se ela não existir
            conexao.Execute("CREATE TABLE IF NOT EXISTS CadastroCliente (id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, nome TEXT NOT NULL, login TEXT NOT NULL, data TEXT NOT NULL, telefone INTEGER NOT NULL, senha TEXT NOT NULL)");
            conexao.Execute("CREATE TABLE IF NOT EXISTS CadastroBebida (id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, nome TEXT NOT NULL, descricao TEXT NOT NULL, valor TEXT NOT NULL, categoria TEXT NOT NULL)");
            conexao.Execute("CREATE TABLE IF NOT EXISTS CadastroPorcao (id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, nome TEXT NOT NULL, descricao TEXT NOT NULL, valor TEXT NOT NULL, categoria TEXT NOT NULL)");
            conexao.Execute("CREATE TABLE IF NOT EXISTS CadastroSuvenir (id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, nome TEXT NOT NULL, descricao TEXT NOT NULL, valor TEXT NOT NULL, categoria TEXT NOT NULL)");
            conexao.Execute("CREATE TABLE IF NOT EXISTS CadastroReserva (id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, nomeCliente TEXT NOT NULL, qtdpessoas INTEGER NOT NULL, data TEXT NOT NULL, observacao TEXT NOT NULL)");
            conexao.Execute("CREATE TABLE IF NOT EXISTS CadastroProgramacao (id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, nomeprog TEXT NOT NULL, data TEXT NOT NULL, descricao TEXT NOT NULL)");

            InitializeComponent();
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
