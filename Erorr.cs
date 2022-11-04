using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace evcplus
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class Erorr : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            
            
            AlertDialog.Builder ob = new AlertDialog.Builder(this);
            ob.SetMessage("pink add kaliso waad qalad");

            ob.SetNegativeButton("ok", delegate
            {
                Intent mv = new Intent(this, typeof(MainActivity));
                StartActivity(mv);

            });

            AlertDialog alert = ob.Create();
            alert.Show();



        }

       




    }
}