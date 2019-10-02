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
	public partial class CuriosidadesPage : ContentPage
	{
		public CuriosidadesPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void BtnVideoSaci_Clicked(object sender, EventArgs e)
        {
            string urlsaci = "https://www.youtube.com/watch?v=uJnvgbEfiHs&t=561s";


            Device.OpenUri(new Uri(urlsaci));

        }

        private void BtnColetaneaLink_Clicked(object sender, EventArgs e)
        {
            string urlsacilivro = "https://sitio.pmvs.pt/wp-content/uploads/2014/06/Monteiro-Lobato-O-Saci.pdf";


            Device.OpenUri(new Uri(urlsacilivro));
       
        }
    }
}