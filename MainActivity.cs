using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Telephony.Euicc;
using Android.Text;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using AlertDialog = Android.App.AlertDialog;

namespace evcplus
{
    [Activity(Label = "@string/app_name",  MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState); 
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.evc);

            // Set our view from the "main" layout resource
            


            AlertDialog.Builder ob = new AlertDialog.Builder(this);
            ob.SetTitle("-EVCPLUS-");
            ob.SetMessage("Fadlan geli PIN-kaaga (Enter PIN)");
            var pincode = new EditText(this);
            pincode.SetLinkTextColor(Color.Red);
            pincode.SetFilters(new IInputFilter[] { new InputFilterLengthFilter(4) });

            pincode.SetRawInputType(Android.Text.InputTypes.ClassNumber);
            ob.SetView(pincode);
            
            ob.SetNegativeButton("cancel", delegate
            {

                
            });


            ob.SetPositiveButton("Send", delegate
            {
                string code = pincode.Text;
                if (code.Equals("9875"))
                {

                    Intent opt = new Intent( this, typeof(Options));
                    StartActivity(opt);

                }

                else
                {

                    Intent erorr = new Intent( this, typeof(Erorr));
                    StartActivity(erorr);

                }

              
            });

         
            AlertDialog alert = ob.Create();
            alert.Show();





         



        }

      

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}