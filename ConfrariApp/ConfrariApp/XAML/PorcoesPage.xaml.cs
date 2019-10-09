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
	public partial class PorcoesPage : ContentPage
	{
        protected Classes.Porcoes porcoes = new Classes.Porcoes();

		public PorcoesPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            CarregarInformacoes();
        }

        private void CarregarInformacoes()
        {
            var lista = porcoes.SelectAll();
            listView.ItemsSource = lista;
        }

        private void ButtonAdicionarPorcao_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdicionarPorcao());
        }

        private void AtualizarPorcao_Clicked(object sender, EventArgs e)
        {

        }

        private void ApagarPorcao_Clicked(object sender, EventArgs e)
        {

        }
    }
}