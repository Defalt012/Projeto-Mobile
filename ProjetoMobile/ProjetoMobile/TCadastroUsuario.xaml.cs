using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoMobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TCadastroUsuario : ContentPage
	{
		public TCadastroUsuario ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
		}

        private void ButtonCadastrar_Clicked(object sender, EventArgs e)
        {
            try
            {
                string sql = String.Format($"INSERT INTO Login  (nome, usuario, email, senha, cep) VALUES ('{0}','{1}','{2}','{3}','{4}',)",entryNomePessoa.Text, entryNomeUsuario.Text, entryEmail.Text, entrySenha.Text,entryCEP.Text);
                ((App)Application.Current).Conexao.Execute(sql);
                DisplayAlert("SUCESSO", "Item inserido", "OK");
            }
            catch
            {
                DisplayAlert("Houve um Problema", "Ocorreu um problema na inserção de dados", "OK");
            }
            
        }
    }
}