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
        protected Classes.Porcoes porcoes = new Classes.Porcoes();

        public AdicionarPorcao ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

      
        private void BtnCadastrarPorcao_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entryNomePorcao.Text) ||
              string.IsNullOrEmpty(entryDescricaoPorcao.Text) ||
              string.IsNullOrEmpty(entryValorPorcao.Text) ||
              string.IsNullOrEmpty(entryCategoriaPorcao.Text))
            {
                DisplayAlert("Ops...", "Não deixe os campos em branco!", "Beleza!");
            }
            else
            {
                bool ResultadoInsert = porcoes.Inserir(entryNomePorcao.Text, entryDescricaoPorcao.Text, entryValorPorcao.Text, entryCategoriaPorcao.Text);
                if (ResultadoInsert == true)
                {
                    DisplayAlert("Sucesso!!", "Produto inserido com sucesso!", "Ok!");
                    entryNomePorcao.Text = "";
                    entryDescricaoPorcao.Text = "";
                    entryValorPorcao.Text = "";
                    entryCategoriaPorcao.Text = "";
                }
            }
        }

        private void BtnLimpar_Clicked(object sender, EventArgs e)
        {
            entryNomePorcao.Text = "";
            entryDescricaoPorcao.Text = "";
            entryValorPorcao.Text = "";
            entryCategoriaPorcao.Text = "";
        }
    }
}