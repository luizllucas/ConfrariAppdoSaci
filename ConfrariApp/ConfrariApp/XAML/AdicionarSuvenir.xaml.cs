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
	public partial class AdicionarSuvenir : ContentPage
	{
        protected Classes.Suvenirs suvenirs = new Classes.Suvenirs();

        public AdicionarSuvenir ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void BtnCadastrarSuvenir_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entryNomeSuvenir.Text) ||
             string.IsNullOrEmpty(entryDescricaoSuvenir.Text) ||
             string.IsNullOrEmpty(entryValorSuvenir.Text) ||
             string.IsNullOrEmpty(entryCategoriaSuvenir.Text))
            {
                DisplayAlert("Ops...", "Não deixe os campos em branco!", "Beleza!");
            }
            else
            {
                bool ResultadoInsert = suvenirs.Inserir(entryNomeSuvenir.Text, entryDescricaoSuvenir.Text, entryValorSuvenir.Text, entryCategoriaSuvenir.Text);
                if (ResultadoInsert == true)
                {
                    DisplayAlert("Sucesso!!", "Suvenir cadastrado!", "Ok!");
                    entryNomeSuvenir.Text = "";
                    entryDescricaoSuvenir.Text = "";
                    entryValorSuvenir.Text = "";
                    entryCategoriaSuvenir.Text = "";
                }
            }
        }

        private void BtnLimpar_Clicked(object sender, EventArgs e)
        {
            entryNomeSuvenir.Text = "";
            entryDescricaoSuvenir.Text = "";
            entryValorSuvenir.Text = "";
            entryCategoriaSuvenir.Text = "";
        }
    }
}