using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace InternshipProject
{
    [Activity(Label = "GameActivity", Theme = "@android:style/Theme.Holo.Light.NoActionBar.Fullscreen")]
    class GameActivity :Activity
    {
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Game);

            TextView txtQuiz = FindViewById<TextView>(Resource.Id.txt_quiz);

            
        }

       
    }
}