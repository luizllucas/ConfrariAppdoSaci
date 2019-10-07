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
		public BebidasPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ButtonAdicionarBebida_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdicionarBebida());
        }
    }
}