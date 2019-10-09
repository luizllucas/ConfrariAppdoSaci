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

        private async void ApagarCliente_Clicked(object sender, EventArgs e)
        {

            var resposta = await DisplayAlert("Confimação", "tem certeza que deseja deletar?", "SIM", "NÃO");
            if (resposta == true)
            {
                try
                {
                    var mi = (MenuItem)sender;
                    var model = (Classes.ModelClientes)mi.CommandParameter;
                    var resultadoDeleteItem = clientes.DeleteItem(model.id, model.nome, model.login, model.data, model.telefone, model.senha);
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