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

        private void BtnLocalização_Clicked(object sender, EventArgs e)
        {
            string urlGps = "https://www.google.com/maps/dir/-22.8826005,-48.4287712/Confraria+do+Saci/@-22.8858305,-48.4365306,16z/data=!3m1!4b1!4m9!4m8!1m1!4e1!1m5!1m1!1s0x94c6df9c144fca6b:0x948a3042fb396fdd!2m2!1d-48.4355352!2d-22.888506";


            Device.OpenUri(new Uri(urlGps));

        }
    }
}