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
	public partial class CadastroCliente : ContentPage
	{
		public CadastroCliente ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            
		}

        private void BtnCadastrar_Clicked(object sender, EventArgs e)
        {
            
        }

        private void BtnLimpar_Clicked(object sender, EventArgs e)
        {
            entryNomeCliente.Text = "";
            entryLoginCliente.Text = "";
            entryDataNascimento.Text = "";
            entrySenha.Text = "";
            entrySenha2.Text = "";
        }
    }
}