using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Android.Runtime;
using Android.Views;
using Android.Content;

using Xamarin.Forms;





namespace GetDone
{
    
    [Activity(Label = "GetDone", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {

        public NavigationPage MainPage { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            SetContentView(Resource.Layout.Login);


            Android.Widget.Button signIn = FindViewById<Android.Widget.Button>(Resource.Id.Signin);
            Android.Widget.Button signUp = FindViewById<Android.Widget.Button>(Resource.Id.SignUp);

            // public void Sign_in_details()
            signIn.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(SignIn));
                StartActivity(intent);
            };
           
            signUp.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(SignUp));
                StartActivity(intent);
            };
        }
    }
}

