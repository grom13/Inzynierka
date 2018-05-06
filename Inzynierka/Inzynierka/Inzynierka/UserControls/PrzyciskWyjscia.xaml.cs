using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inzynierka.UserControls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrzyciskWyjscia : Grid
	{
		public PrzyciskWyjscia ()
		{
			InitializeComponent ();
		}

        private void btnWyjscie(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Wyjscia());
        }
    }
}