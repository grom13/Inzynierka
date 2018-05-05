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
	public partial class PrzyciskWejscia : Grid
	{
		public PrzyciskWejscia ()
		{
			InitializeComponent ();
		}
        private void btnWejscie(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Wejscie());
        }
    }
}