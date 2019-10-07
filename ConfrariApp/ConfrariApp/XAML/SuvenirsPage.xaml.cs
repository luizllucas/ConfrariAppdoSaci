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
	public partial class SuvenirsPage : ContentPage
	{
		public SuvenirsPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ButtonAdicionarSuvenir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdicionarSuvenir());
        }
    }
}