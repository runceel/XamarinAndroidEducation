
using Android.App;
using Android.OS;
using Android.Widget;

namespace NavigationApp
{
    [Activity(Label = "NextActivity")]
    public class NextActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.SetContentView(Resource.Layout.Next);

            var textView = this.FindViewById<TextView>(Resource.Id.TextViewGreetMessage);
            textView.Text = this.Intent.GetStringExtra("Message");
        }
    }
}