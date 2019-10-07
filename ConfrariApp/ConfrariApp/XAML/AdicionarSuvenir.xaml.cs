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
	public partial class AdicionarSuvenir : ContentPage
	{
		public AdicionarSuvenir ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void BtnCadastrarSuvenir_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Clicked(object sender, EventArgs e)
        {

        }
    }
}