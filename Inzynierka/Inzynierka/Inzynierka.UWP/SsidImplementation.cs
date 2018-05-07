using Inzynierka.Interfaces;
using Inzynierka.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Connectivity;

[assembly: Xamarin.Forms.Dependency(typeof(SsidImplementation))]
namespace Inzynierka.UWP
{
    class SsidImplementation : ISsid
    {
        public string ssidName
        {
            get
            {
                if (CrossConnectivity.Current.IsConnected)
                {

                    var profile = Windows.Networking.Connectivity.NetworkInformation.GetInternetConnectionProfile();
                    var x = profile.GetSignalBars();
                    if (profile.IsWlanConnectionProfile)
                    {
                        return profile.WlanConnectionProfileDetails.GetConnectedSsid() + "  " + (x * (int)25) + "%";
                    }
                }
                return "Brak sieci";
            }
        }
    }
}

