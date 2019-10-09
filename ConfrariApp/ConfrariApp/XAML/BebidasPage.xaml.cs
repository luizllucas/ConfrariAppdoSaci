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
	public partial class BebidasPage : ContentPage
	{
        protected Classes.Bebidas bebidas = new Classes.Bebidas();

		public BebidasPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            CarregarInformacoes();
        }

        private void CarregarInformacoes()
        {
            var lista = bebidas.SelectAll();
            listView.ItemsSource = lista;        
        }

        private void ButtonAdicionarBebida_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdicionarBebida());
            CarregarInformacoes();
        }

        private void AtualizarBebida_Clicked(object sender, EventArgs e)
        {

        }

        private async void ApagarBebida_Clicked(object sender, EventArgs e)
        {

            var resposta = await DisplayAlert("Confimação", "tem certeza que deseja deletar?", "SIM", "NÃO");
            if (resposta == true)
            {
                try
                {
                    var mi = (MenuItem)sender;
                    var model = (Classes.ModelProdutos)mi.CommandParameter;
                    var resultadoDeleteItem = bebidas.DeleteItem(model.id, model.nome, model.descricao, model.valor, model.categoria);
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