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
		}

        private void BtnCardápio_Clicked(object sender, EventArgs e)
        {

        }
    }
}