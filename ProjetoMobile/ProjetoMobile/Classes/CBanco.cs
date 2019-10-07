using PCLExt.FileStorage.Folders;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace ProjetoMobile.Classes
{
    public class CBanco
    {
        public SQLite.SQLiteConnection Conexao { get; private set; }

        public void Banco()
        {
            try
            {
                var Pasta = new LocalRootFolder();
                var Banco = Pasta.CreateFile("BancoX.db", PCLExt.FileStorage.CreationCollisionOption.OpenIfExists);
                Conexao = new SQLite.SQLiteConnection(Banco.Path);

                Conexao.Execute("CREATE TABLE IF NOT EXISTS Login (id INTEGER PRIMARY KEY AUTOINCREMENT NOTNULL UNIQUE" +
                    ", nome TEXT NOTNULL, usuario TEXT NOTNULL UNIQUE, email TEXT NOTNULL UNIQUE, senha TEXT NOTNULL, cep NOTNULL)");

            }
            catch
            {
                //DisplayAlert("Houveu um Problema", "Banco de dados", "OK");

            }
        }

    }
}
