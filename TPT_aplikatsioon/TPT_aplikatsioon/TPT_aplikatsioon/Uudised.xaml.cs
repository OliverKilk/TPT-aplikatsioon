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
	public partial class Uudised : ContentPage
	{
		public Uudised ()
		{
			InitializeComponent ();
            browser_uudised.Source = "https://www.tptlive.ee/category/uudised/";
        }
	}
}