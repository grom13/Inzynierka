using Inzynierka.Interfaces;
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
	public partial class Toolbar : Grid
	{
		public Toolbar ()
		{
            IBattery battery;
            ISsid ssid;
            InitializeComponent ();
            ObslugaToolbaru();
		}
        async void ObslugaToolbaru()
        {
            while (true)
            {
              
                lblBateria.Text = DependencyService.Get<IBattery>().RemainingChargePercent.ToString()+"%";
                lblWifi.Text = DependencyService.Get<ISsid>().ssidName;
                await Task.Delay(5000);

            }
        }

        private void btnEsc(object sender, EventArgs e)
        {
            var closer = DependencyService.Get<ICloseApplication>();
            closer.closeApplication();
        }
        private void btnWstecz(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}