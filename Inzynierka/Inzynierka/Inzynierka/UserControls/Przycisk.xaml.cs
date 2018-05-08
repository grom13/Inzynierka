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
	public partial class Przycisk : Grid
	{
		public Przycisk ()
		{
			InitializeComponent ();
		}
        
        public string Ikona
        {
            set
            {
                imgIkona.Source = value;
            }
        }

        public string Tytul
        {
            set
            {
                lblTytul.Text = value;
            }
        }

        public Color Tlo
        {
            set
            {
                gridTlo.BackgroundColor = value;
            }
        }
    }
}