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
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        private void BtnEntrar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entryLogin.Text) ||
               (string.IsNullOrEmpty(entrySenha.Text)))
            {
                DisplayAlert("Ops...", "Não deixe os campos em branco.", "Beleza!");
            }           
            else if (entryLogin.Text == "admin" ||
                    entrySenha.Text == "admin")
            {
                
                string cliente = entryLogin.Text;
                Navigation.PushAsync(new MenuPrincipalCliente());
            }
        }

        private void BtnCadastrarLogin_Clicked(object sender, EventArgs e)
        {

        }
    }
}