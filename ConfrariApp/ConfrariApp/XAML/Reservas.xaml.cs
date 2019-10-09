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
            CarregarInformacoes();
        }

        private void AtualizarReserva_Clicked(object sender, EventArgs e)
        {

        }

        private async void ApagarReserva_Clicked(object sender, EventArgs e)
        {

            var resposta = await DisplayAlert("Confimação", "tem certeza que deseja deletar?", "SIM", "NÃO");
            if (resposta == true)
            {
                try
                {
                    var mi = (MenuItem)sender;
                    var model = (Classes.ModelReservas)mi.CommandParameter;
                    var resultadoDeleteItem = reservas.DeleteItem(model.id, model.nomeCliente, model.qtdpessoas, model.data, model.observacao);
                    if (resultadoDeleteItem == true)
                        await DisplayAlert("Sucesso!", "Item Deletado", "OK");
                    else
                        await DisplayAlert("Ops...", "Houve um erro", "OK");
                }
                catch (Exception ex)
                {
                    await DisplayAlert("ERRO", ex.Message, "OK");
                }
            }
            CarregarInformacoes();
        }
    }
}