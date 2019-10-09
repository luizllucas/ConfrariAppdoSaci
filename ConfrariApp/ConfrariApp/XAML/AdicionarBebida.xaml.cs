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
	public partial class AdicionarBebida : ContentPage
	{
        protected Classes.Bebidas bebidas = new Classes.Bebidas();

		public AdicionarBebida ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }


        private void BtnCadastrarBebida_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entryNomeBebida.Text) ||
                string.IsNullOrEmpty(entryDescricaoBebida.Text) ||
                string.IsNullOrEmpty(entryValorBebida.Text) ||
                string.IsNullOrEmpty(entryCategoriaBebida.Text))
            {
                DisplayAlert("Ops...", "Não deixe os campos em branco!", "Beleza!");
            }
            else
            {
                bool ResultadoInsert = bebidas.Inserir(entryNomeBebida.Text, entryDescricaoBebida.Text, entryValorBebida.Text, entryCategoriaBebida.Text);
                if (ResultadoInsert == true)
                {
                    DisplayAlert("Sucesso!!", "Produto inserido com sucesso!", "Ok!");
                    entryNomeBebida.Text = "";
                    entryDescricaoBebida.Text = "";
                    entryValorBebida.Text = "";
                    entryCategoriaBebida.Text = "";
                }
            }
        }

        private void BtnLimpar_Clicked(object sender, EventArgs e)
        {
            entryNomeBebida.Text = "";
            entryDescricaoBebida.Text = "";
            entryValorBebida.Text = "";
            entryCategoriaBebida.Text = "";
        }
    }
}