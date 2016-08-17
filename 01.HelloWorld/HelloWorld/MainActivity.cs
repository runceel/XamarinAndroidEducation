using Android.App;
using Android.OS;
using Android.Widget;

namespace HelloWorld
{
    [Activity(Label = "HelloWorld", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            this.SetContentView(Resource.Layout.Main);

            var button = this.FindViewById<Button>(Resource.Id.MyButton);
            var height = this.FindViewById<EditText>(Resource.Id.EditTextHeight);
            var weight = this.FindViewById<EditText>(Resource.Id.EditTextWeight);

            button.Click += (_, __) =>
            {
                double h;
                if (!double.TryParse(height.Text, out h))
                {
                    return;
                }

                double w;
                if (!double.TryParse(weight.Text, out w))
                {
                    return;
                }

                // 体重(kg) ÷ {身長(m) Ｘ 身長(m)}
                var bmi = w / (h * h);
                button.Text = string.Format(this.Resources.GetString(Resource.String.BmiMessage ,bmi));
            };
        }
    }
}

