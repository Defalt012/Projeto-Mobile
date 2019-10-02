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
	public partial class TelaHamburguer : MasterDetailPage
	{
		public TelaHamburguer ()
		{
			InitializeComponent ();
            Detail = new NavigationPage(new TMenu());
        }

        private void PaginaLimpar_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TComodosEDia());
            IsPresented = false;
        }

        private void PaginaParticipar_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TCadastroEmpregados());
            IsPresented = false;
        }

        private void PaginaPedido_Tapped(object sender, EventArgs e)
        {
            //Detail = new NavigationPage(new TComodosEDia());
            //IsPresented = false;
        }

        private void PaginaConta_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TContaUsuario());
            IsPresented = false;
        }
    }
}