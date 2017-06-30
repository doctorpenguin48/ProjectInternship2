using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Content;

namespace InternshipProject
{
    [Activity(Label = "InternshipProject", MainLauncher = true, Icon = "@drawable/icon" ,Theme="@android:style/Theme.Holo.Light.NoActionBar.Fullscreen")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button btn_start = FindViewById<Button>(Resource.Id.btn_start);
            btn_start.Click += delegate
            {
                StartActivity(typeof(GameActivity));
            };

        }

    }
}

