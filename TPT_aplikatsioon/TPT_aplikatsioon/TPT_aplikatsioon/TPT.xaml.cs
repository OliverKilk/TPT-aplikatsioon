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
	public partial class TPT : ContentPage
	{
		public TPT ()
		{
			InitializeComponent ();
            tptlogo.Source = ImageSource.FromFile("tpt_logo2.png");
            browser_tutvustus.Source = "https://et.wikipedia.org/wiki/Tallinna_Pol%C3%BCtehnikum";
        }
	}
}