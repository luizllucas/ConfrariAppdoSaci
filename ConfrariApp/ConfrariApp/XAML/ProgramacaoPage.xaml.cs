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
	public partial class ProgramacaoPage : ContentPage
	{
        protected Classes.Programacao prog = new Classes.Programacao();

		public ProgramacaoPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            CarregarInformacoes();
        }

        private void CarregarInformacoes()
        {
            var lista = prog.SelectAll();
            listView.ItemsSource = lista;
        }

        private void ButtonAdicionarProgramacao_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdicionarProgramacao());
            CarregarInformacoes();
        }

        private void AtualizarProgramacao_Clicked(object sender, EventArgs e)
        {

        }

        private async void ApagarProgramacao_Clicked(object sender, EventArgs e)
        {

            var resposta = await DisplayAlert("Confimação", "tem certeza que deseja deletar?", "SIM", "NÃO");
            if (resposta == true)
            {
                try
                {
                    var mi = (MenuItem)sender;
                    var model = (Classes.ModelProgramacao)mi.CommandParameter;
                    var resultadoDeleteItem = prog.DeleteItem(model.id, model.nomeprog, model.data, model.descricao);
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