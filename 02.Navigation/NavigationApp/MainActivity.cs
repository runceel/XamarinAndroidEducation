using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;
using Java.Interop;

namespace NavigationApp
{
    [Activity(Label = "NavigationApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            this.SetContentView(Resource.Layout.Main);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            this.MenuInflater.Inflate(Resource.Menu.MainMenu, menu);
            return true;
        }

        [Export(nameof(NavigateMenuClick))]
        public void NavigateMenuClick(IMenuItem menuItem)
        {
            // NextActivityへのIntentを作成して
            var intent = new Intent(this, typeof(NextActivity));
            // データを詰めて
            intent.PutExtra("Message", this.FindViewById<EditText>(Resource.Id.GreetMessage).Text);

            this.StartActivity(intent);
        }
    }
}

