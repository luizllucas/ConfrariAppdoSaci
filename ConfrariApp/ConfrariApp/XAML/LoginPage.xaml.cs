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
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void BtnEntrar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entryLogin.Text) ||
               (string.IsNullOrEmpty(entrySenha.Text)))
            {
                DisplayAlert("Ops...", "Não deixe os campos em branco.", "Beleza!");
            }
            else
            {

                Classes.Clientes usuario = new Classes.Clientes();
                int resultadoLogin = usuario.Login(entryLogin.Text, entrySenha.Text);

                if (resultadoLogin == 1)
                {
                    Navigation.PushAsync(new MenuPrincipalCliente());

                }
                else
                {
                    DisplayAlert("Erro..", "Usuário ou senha incorretos!", "Tente novamente");
                }
            }
           
        }

        private void BtnCadastrarLogin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroCliente());
        }

        private void BtnFacebook_Clicked(object sender, EventArgs e)
        {
            string urlFace = "https://www.facebook.com";


            Device.OpenUri(new Uri(urlFace));
            Navigation.PushAsync(new MenuPrincipalCliente());
        }
    }
}