using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PCLExt.FileStorage.Folders;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ProjetoMobile
{
    public partial class App : Application
    {
        public SQLite.SQLiteConnection Conexao { get; private set; }

        public App()
        {
            var Pasta = new LocalRootFolder();
            var Banco = Pasta.CreateFile("BancoX.db", PCLExt.FileStorage.CreationCollisionOption.OpenIfExists);
            Conexao = new SQLite.SQLiteConnection(Banco.Path);

            Conexao.Execute("CREATE TABLE IF NOT EXISTS Login (id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE" +
                ", nome TEXT NOT NULL, usuario TEXT NOT NULL UNIQUE, email TEXT NOT NULL UNIQUE, senha TEXT NOT NULL, cep NOT NULL)");

            InitializeComponent();

            MainPage = new NavigationPage(new TelaHamburguer());
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
