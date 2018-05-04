using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inzynierka
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EkranStartowy : ContentPage
	{
		public EkranStartowy ()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent ();
		}
        private void btnWejscie(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Wejscie());
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (height > width)
            {
                Pionowy.IsVisible = true;

            }
            else
            {
                Pionowy.IsVisible = false;
            }
            if (width > height)
            {
                Poziomy.IsVisible = true;

            }
            else
            {
                Poziomy.IsVisible = false;
            }

        }
    }
}