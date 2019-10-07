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
	public partial class AdicionarPorcao : ContentPage
	{
		public AdicionarPorcao ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void BtnCadastrarPorcao_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Clicked(object sender, EventArgs e)
        {

        }
    }
}