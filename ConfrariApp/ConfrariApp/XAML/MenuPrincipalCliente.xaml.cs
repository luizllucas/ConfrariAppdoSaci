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
	public partial class MenuPrincipalCliente : ContentPage
	{
		public MenuPrincipalCliente ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void BtnCardápio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CardapioPage());
        }

        private void BtnReservas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Reservas());
        }

        private void BtnProgramacao_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProgramacaoPage());
        }

        private void BtnCuriosidades_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CuriosidadesPage());
        }
    }
}