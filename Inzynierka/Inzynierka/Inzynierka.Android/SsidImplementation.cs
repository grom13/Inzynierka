using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Net.Wifi;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Inzynierka.Droid;
using Inzynierka.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(SsidImplementation))]
namespace Inzynierka.Droid
{
    class SsidImplementation : ISsid
    {
        public string ssidName
        {
            get
            {
                WifiManager wifiManager = (WifiManager)(Application.Context.GetSystemService(Context.WifiService));

                if (wifiManager != null)
                {
                    int dBm = wifiManager.ConnectionInfo.Rssi;
                    int quality;
                    if (dBm <= -100)
                        quality = 0;
                    else if (dBm >= -50)
                        quality = 100;
                    else
                        quality = 2 * (dBm + 100);
                   // quality /= 25;
                    return wifiManager.ConnectionInfo.SSID + "  " + quality+"%";

                }
                else
                {
                    return "WiFiManager is NULL";
                }
            }
        }
    }
}