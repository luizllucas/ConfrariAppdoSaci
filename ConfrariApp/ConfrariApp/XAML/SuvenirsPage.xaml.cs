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
	public partial class SuvenirsPage : ContentPage
	{
        protected Classes.Suvenirs suvenirs = new Classes.Suvenirs();

		public SuvenirsPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            CarregarInformacoes();
        }

        private void CarregarInformacoes()
        {
            var lista = suvenirs.SelectAll();
            listView.ItemsSource = lista;
        }

        private void ButtonAdicionarSuvenir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdicionarSuvenir());
        }

        private void AtualizarSuvenir_Clicked(object sender, EventArgs e)
        {

        }

        private void ApagarSuvenir_Clicked(object sender, EventArgs e)
        {

        }
    }
}