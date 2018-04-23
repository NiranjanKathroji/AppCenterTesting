using Android.App;
using Android.Widget;
using Android.OS;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace AppCenterTesting
{
    [Activity(Label = "AppCenterTesting", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            AppCenter.Start("9b3279d4-48e9-4877-90aa-5b073b9c160a",
                   typeof(Analytics), typeof(Crashes));
        }
    }
}

