using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConfrariApp.XAML
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConsultarCliente : ContentPage
	{
		public ConsultarCliente ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void AtualizarCliente_Clicked()
        {

        }
    }
}