using Android.App;
using Android.Content;
using Android.OS;
using Android.Util;
using Android.Views;
using Java.Interop;
using System;

namespace ActivityLifecycle
{
    [Activity(Label = "ActivityLifecycle", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private string Id { get; set; }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            Log.Debug(nameof(MainActivity), $"{nameof(OnSaveInstanceState)}: {this.Id}");
            outState.PutString(nameof(Id), this.Id);
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            this.SetContentView(Resource.Layout.Main);

            if (bundle == null)
            {
                this.Id = Guid.NewGuid().ToString();
            }
            else
            {
                this.Id = bundle.GetString(nameof(Id));
            }
            Log.Debug(nameof(MainActivity), $"{nameof(OnCreate)}: {this.Id}");
        }

        protected override void OnStart()
        {
            base.OnStart();
            Log.Debug(nameof(MainActivity), $"{nameof(OnStart)}: {this.Id}");
        }

        protected override void OnResume()
        {
            base.OnResume();
            Log.Debug(nameof(MainActivity), $"{nameof(OnResume)}: {this.Id}");
        }

        protected override void OnRestart()
        {
            base.OnRestart();
            Log.Debug(nameof(MainActivity), $"{nameof(OnRestart)}: {this.Id}");
        }

        protected override void OnPause()
        {
            base.OnPause();
            Log.Debug(nameof(MainActivity), $"{nameof(OnPause)}: {this.Id}");
        }

        protected override void OnStop()
        {
            base.OnStop();
            Log.Debug(nameof(MainActivity), $"{nameof(OnStop)}: {this.Id}");
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            Log.Debug(nameof(MainActivity), $"{nameof(OnDestroy)}: {this.Id}");
        }

        [Export(nameof(MyButtonClick))]
        public void MyButtonClick(View v)
        {
            this.StartActivity(new Intent(this, typeof(NextActivity)));
        }
    }
}

