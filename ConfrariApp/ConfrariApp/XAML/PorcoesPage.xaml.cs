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
            CarregarInformacoes();
        }

        private void AtualizarPorcao_Clicked(object sender, EventArgs e)
        {

        }

        private async void ApagarPorcao_Clicked(object sender, EventArgs e)
        {

            var resposta = await DisplayAlert("Confimação", "tem certeza que deseja deletar?", "SIM", "NÃO");
            if (resposta == true)
            {
                try
                {
                    var mi = (MenuItem)sender;
                    var model = (Classes.ModelProdutos)mi.CommandParameter;
                    var resultadoDeleteItem = porcoes.DeleteItem(model.id, model.nome, model.descricao, model.valor, model.categoria);
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