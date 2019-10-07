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

            Conexao.Execute("CREATE TABLE IF NOT EXISTS Login (id INTEGER PRIMARY KEY AUTOINCREMENT NOTNULL UNIQUE" +
                ", nome TEXT NOTNULL, usuario TEXT NOTNULL UNIQUE, email TEXT NOTNULL UNIQUE, senha TEXT NOTNULL, cep NOTNULL)");

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
