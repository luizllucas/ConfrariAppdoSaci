using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConfrariApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Reservas : ContentPage
	{
        protected Classes.Reservas reservas = new Classes.Reservas();

		public Reservas ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            CarregarInformacoes();
        }

        private void CarregarInformacoes()
        {
            var lista = reservas.SelectAll();
            listView.ItemsSource = lista;
        }

        private void ButtonAdicionarReserva_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdicionarReserva());
        }

        private void AtualizarReserva_Clicked(object sender, EventArgs e)
        {

        }

        private void ApagarReserva_Clicked(object sender, EventArgs e)
        {

        }
    }
}