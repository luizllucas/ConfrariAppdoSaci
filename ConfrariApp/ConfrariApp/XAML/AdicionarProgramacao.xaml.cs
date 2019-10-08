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
	public partial class AdicionarProgramacao : ContentPage
	{
        protected Classes.Programacao prog = new Classes.Programacao();

		public AdicionarProgramacao ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void BtnCadastrarProgramacao_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entryNomeProgramacao.Text) ||
             string.IsNullOrEmpty(entryDataProgramacao.Text) ||
             string.IsNullOrEmpty(entryDescricaoProgramacao.Text))
            {
                DisplayAlert("Ops...", "Não deixe os campos em branco!", "Beleza!");
            }
            else
            {
                bool ResultadoInsert = prog.Inserir(entryNomeProgramacao.Text, entryDataProgramacao.Text, entryDescricaoProgramacao.Text);
                if (ResultadoInsert == true)
                {
                    DisplayAlert("Sucesso!!", "Produto inserido com sucesso!", "Ok!");
                    entryNomeProgramacao.Text = "";
                    entryDataProgramacao.Text = "";
                    entryDescricaoProgramacao.Text = "";
                    
                }
            }
        }

        private void BtnLimpar_Clicked(object sender, EventArgs e)
        {
            entryNomeProgramacao.Text = "";
            entryDataProgramacao.Text = "";
            entryDescricaoProgramacao.Text = "";
        }
    }
}