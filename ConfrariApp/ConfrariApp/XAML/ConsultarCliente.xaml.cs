using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConfrariApp.XAML
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConsultarCliente : ContentPage
	{
        protected Classes.Clientes clientes = new Classes.Clientes();

		public ConsultarCliente ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            CarregarInformacoes();
        }


        private void CarregarInformacoes()
        {
            var lista = clientes.SelectAll();
            listView.ItemsSource = lista;
        }

        private void AtualizarCliente_Clicked(object sender, EventArgs e)
        {

        }

        private void ApagarCliente_Clicked(object sender, EventArgs e)
        {

        }
    }
}