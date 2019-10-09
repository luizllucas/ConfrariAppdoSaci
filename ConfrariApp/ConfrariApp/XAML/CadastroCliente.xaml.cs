using ConfrariApp.XAML;
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
        protected Classes.Clientes clientes = new Classes.Clientes();
		public CadastroCliente ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            
		}      

        private void BtnLimpar_Clicked(object sender, EventArgs e)
        {
            entryNomeCliente.Text = "";
            entryLoginCliente.Text = "";
            entryDataNascimento.Text = "";
            entrySenha.Text = "";
            entrySenha2.Text = "";
        }

        private void BtnConsultar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConsultarCliente());
        }

        private void BtnCadastrarCliente_Clicked(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(entryNomeCliente.Text) ||
                     string.IsNullOrEmpty(entryLoginCliente.Text) ||
                    string.IsNullOrEmpty(entryDataNascimento.Text) ||
                    string.IsNullOrEmpty(entryTelefone.Text) ||
                    string.IsNullOrEmpty(entrySenha.Text))
                {
                    DisplayAlert("Ops...", "Não deixe os campos em branco!", "Beleza!");
                }
                else
                {
                    bool ResultadoInsert = clientes.Inserir(entryNomeCliente.Text, entryLoginCliente.Text, entryDataNascimento.Text, entryTelefone.Text, entrySenha.Text);
                    if (ResultadoInsert == true)
                    {
                        DisplayAlert("Sucesso!!", "Produto inserido com sucesso!", "Ok!");
                        entryNomeCliente.Text = "";
                        entryLoginCliente.Text = "";
                        entryDataNascimento.Text = "";
                        entryTelefone.Text = "";
                        entrySenha.Text = "";
                    }
                }
            }
        }
    }
}