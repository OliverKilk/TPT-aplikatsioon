using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TPT_aplikatsioon
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Lingid : ContentPage
	{
		public Lingid ()
		{
			InitializeComponent ();
            Siseveeb.Clicked += btnSiseveeb_Clicked;
            Tunniplaan.Clicked += btnTunniplaan_Clicked;
            Õppetoetused.Clicked += btnÕppetoetused_Clicked;
            Õpilaskodu.Clicked += btnÕpilaskodu_Clicked;
        }
        private void btnSiseveeb_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://tpt.siseveeb.ee/"));
        }

        private void btnTunniplaan_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://tpt.siseveeb.ee/veebivormid/tunniplaan"));
        }

        private void btnÕppetoetused_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.tptlive.ee/oppetoo/oppekorralduseeskiri/"));
        }

        private void btnÕpilaskodu_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.google.com"));
        }
    }
}