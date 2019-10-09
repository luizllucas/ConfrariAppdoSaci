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
            CarregarInformacoes();
        }

        private void AtualizarSuvenir_Clicked(object sender, EventArgs e)
        {

        }

        private async void ApagarSuvenir_Clicked(object sender, EventArgs e)
        {

            var resposta = await DisplayAlert("Confimação", "tem certeza que deseja deletar?", "SIM", "NÃO");
            if (resposta == true)
            {
                try
                {
                    var mi = (MenuItem)sender;
                    var model = (Classes.ModelProdutos)mi.CommandParameter;
                    var resultadoDeleteItem = suvenirs.DeleteItem(model.id, model.nome, model.descricao, model.valor, model.categoria);
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