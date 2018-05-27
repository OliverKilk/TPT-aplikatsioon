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
	public partial class Tunniplaan : ContentPage
	{
		public Tunniplaan ()
		{
			InitializeComponent ();
            browser_tunniplaan.Source = "https://tpt.siseveeb.ee/veebivormid/tunniplaan/tunniplaan?oppegrupp=171&nadal=21.05.2018";
		}
	}
}