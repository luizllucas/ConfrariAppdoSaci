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
        }

        private void AtualizarProgramacao_Clicked(object sender, EventArgs e)
        {

        }

        private void ApagarProgramacao_Clicked(object sender, EventArgs e)
        {

        }
    }
}