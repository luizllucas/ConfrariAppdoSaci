﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConfrariApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BebidasPage : ContentPage
	{
        protected Classes.Produtos produtos = new Classes.Produtos();

		public BebidasPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            CarregarInformacoes();
        }

        private void CarregarInformacoes()
        {
            var lista = produtos.SelectAll();
            listView.ItemsSource = lista;        
        }

        private void ButtonAdicionarBebida_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdicionarBebida());
        }

        private void AtualizarBebida_Clicked(object sender, EventArgs e)
        {

        }

        private void ApagarBebida_Clicked(object sender, EventArgs e)
        {

        }
    }
}