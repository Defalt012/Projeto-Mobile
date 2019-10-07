using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjetoMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonCriarConta_Clicked(object sender, EventArgs e)
        {
            
        }

        private void ButtonLogar_Clicked(object sender, EventArgs e)
        {
            try
            {
                string sql = String.Format($"SELECT COUNT(*) from Login where email = '{0}' and senha = '{1}'", entryNome.Text, entrySenha.Text);
                ((App)Application.Current).Conexao.Execute(sql);
                DisplayAlert("SUCESSO", "Item inserido", "OK");

            }
            catch
            {

            }

            
        }
    }
}
