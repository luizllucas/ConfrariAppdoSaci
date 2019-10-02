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
	public partial class CardapioPage : ContentPage
	{
		public CardapioPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void BtnBebidas_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnPorcoes_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnSuvenirs_Clicked(object sender, EventArgs e)
        {

        }
    }
}