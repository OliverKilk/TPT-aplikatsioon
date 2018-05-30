using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace TPT_aplikatsioon.Droid
{
    [Activity(Label = "TPT_aplikatsioon", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            AppCenter.Start("90b17edc-a023-490a-b35b-07c23f1a48f9",
                   typeof(Analytics), typeof(Crashes));
            AppCenter.Start("90b17edc-a023-490a-b35b-07c23f1a48f9", typeof(Analytics), typeof(Crashes));
        }
    }
}

