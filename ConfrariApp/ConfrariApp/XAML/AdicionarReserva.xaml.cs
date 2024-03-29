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
	public partial class AdicionarReserva : ContentPage
	{
        protected Classes.Reservas reservas = new Classes.Reservas();

		public AdicionarReserva ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void BtnCadastrarReserva_Clicked(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(entryNomeclienteReserva.Text) ||
             string.IsNullOrEmpty(entryQtdPessoas.Text) ||
             string.IsNullOrEmpty(entryDataReserva.Text) ||
             string.IsNullOrEmpty(entryObsReserva.Text))
            {
                DisplayAlert("Ops...", "Não deixe os campos em branco!", "Beleza!");
            }
            else
            {
                bool ResultadoInsert = reservas.Inserir(entryNomeclienteReserva.Text, entryQtdPessoas.Text, entryDataReserva.Text, entryObsReserva.Text);
                if (ResultadoInsert == true)
                {
                    DisplayAlert("Sucesso!!", "Reserva cadastrada!", "Ok!");
                    entryNomeclienteReserva.Text = "";
                    entryQtdPessoas.Text = "";
                    entryDataReserva.Text = "";
                    entryObsReserva.Text = "";

                }
            }
        }

        private void BtnLimpar_Clicked(object sender, EventArgs e)
        {
            entryNomeclienteReserva.Text = "";
            entryQtdPessoas.Text = "";
            entryDataReserva.Text = "";
            entryObsReserva.Text = "";
        }
    }
}