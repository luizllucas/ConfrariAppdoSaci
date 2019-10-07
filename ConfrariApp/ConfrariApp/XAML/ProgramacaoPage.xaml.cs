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
	public partial class ProgramacaoPage : ContentPage
	{
		public ProgramacaoPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ButtonAdicionarProgramacao_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdicionarProgramacao());
        }
    }
}