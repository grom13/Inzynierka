﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inzynierka.UserControls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Stopka : Grid
	{
		public Stopka ()
		{
			InitializeComponent ();
		}
	}
}