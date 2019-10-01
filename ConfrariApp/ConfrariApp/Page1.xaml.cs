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
	public partial class Page1 : MasterDetailPage
	{
		public Page1 ()
		{
			InitializeComponent ();
            Detail = new CardapioPage();
        }

        private void PaginaBebidas_Tapped(object sender, EventArgs e)
        {

        }

        private void PaginaPorcoes_Tapped(object sender, EventArgs e)
        {

        }

        private void PaginaSuvenirs_Tapped(object sender, EventArgs e)
        {

        }
    }
}