using Android.App;
using Android.Widget;
using Android.OS;
using System;






namespace GetDone
{
    
    [Activity(Label = "GetDone", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        //int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            SetContentView(Resource.Layout.Login);

           
            Button button = FindViewById<Button>(Resource.Id.Signin);

           // public void Sign_in_details()

            //button.Click += delegate { button.Text = $"{count++} clicks!"; };
        }
    }
}

