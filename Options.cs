using Android.App;
using Android.Content;
using Android.OS;
using Android.Text;
using Android.Widget;
using Java.Text;
using Java.Util;
using System;
using System.Collections.Generic;
using System.Net;
using System.Collections.Specialized;
using Android.Systems;
using System.IO;
using System.Text;

namespace evcplus
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class Options : Activity
    {



        protected override void OnCreate(Bundle savedInstanceState)
        {


            StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().PermitAll().Build();
            StrictMode.SetThreadPolicy(policy);

            base.OnCreate(savedInstanceState);



            AlertDialog.Builder ob = new AlertDialog.Builder(this);
            ob.SetTitle("-[EVCPLUS]-");
            ob.SetMessage("1. Itus Haraaga \n 2. Karkaa hadalka\n 3. Bixi Biil\n 4. U wareeji EVCPlus\n 5. Warbixin Kooban\n 6. Salaam Bank\n 7. Maareynta\n 8. TAAJ\n 9. Bill P ayment");
            var op = new EditText(this);

            op.SetFilters(new IInputFilter[] { new InputFilterLengthFilter(1) });

            op.SetRawInputType(Android.Text.InputTypes.ClassNumber);
            ob.SetView(op);




            ob.SetNegativeButton("cancel", delegate
            {


            });


            ob.SetPositiveButton("Send", delegate
            {

                string opt = op.Text;

                if (opt.Equals(""))
                {

                    AlertDialog.Builder op = new AlertDialog.Builder(this);
                    op.SetMessage("fadlan optinos kili");

                    op.SetNegativeButton("ok", delegate
                    {
                        Intent mv = new Intent(this, typeof(Options));
                        StartActivity(mv);

                    });

                    AlertDialog alert = op.Create();
                    alert.Show();
                }

                else if (opt.Equals("1"))
                {
                    AlertDialog.Builder op1 = new AlertDialog.Builder(this);
                    op1.SetMessage("<-EVCPlus-> Haraagaagu waa $200");
                    op1.SetNegativeButton("ok", delegate
                    {


                        Intent ii = new Intent(this, typeof(Options));
                        StartActivity(ii);

                    });
                    AlertDialog opt1 = op1.Create();
                    opt1.Show();



                }
                else if (opt.Equals("2"))
                {




                }

                else if (opt.Equals("3"))
                {




                }
                else if (opt.Equals("4"))
                {

                    /////////start///////////
                    AlertDialog.Builder op4 = new AlertDialog.Builder(this);
                    op4.SetMessage("Fadlan Geli Mobile-ka");
                    EditText phone = new EditText(this);

                    phone.SetFilters(new IInputFilter[] { new InputFilterLengthFilter(9) });

                    phone.SetRawInputType(Android.Text.InputTypes.ClassNumber);
                    op4.SetView(phone);
                    ////cancel phone
                    op4.SetNegativeButton("cancel", delegate
                    {


                    });




                    /// send phone 
                    op4.SetPositiveButton("send", delegate
                    {

                        AlertDialog.Builder alertmoney = new AlertDialog.Builder(this);
                        alertmoney.SetMessage("Fadlan Geli lacagta");
                        EditText money = new EditText(this);
                        money.SetFilters(new IInputFilter[] { new InputFilterLengthFilter(1000) });
                        money.SetRawInputType(Android.Text.InputTypes.ClassNumber);
                        alertmoney.SetView(money);

                        ////cancel config

                        alertmoney.SetNegativeButton("cancel", delegate
                        {

                        });


                        ////config money

                        alertmoney.SetPositiveButton("send", delegate
                        {

                            AlertDialog.Builder config = new AlertDialog.Builder(this);
                            config.SetMessage("Ma hubtaa inaad $" + money.Text + " " + " u wareejisid 252" + phone.Text + "? \n 1.Haa\n 2.Maya");
                            EditText configmoney = new EditText(this);
                            configmoney.SetFilters(new IInputFilter[] { new InputFilterLengthFilter(1) });
                            configmoney.SetRawInputType(Android.Text.InputTypes.ClassNumber);
                            config.SetView(configmoney);

                            config.SetNegativeButton("cancel", delegate
                            {


                            });




                            config.SetPositiveButton("send", delegate
                            {

                                string conopt = configmoney.Text;

                                if (conopt.Equals(""))
                                {

                                    AlertDialog.Builder op = new AlertDialog.Builder(this);
                                    op.SetMessage("fadlan optinos 1 am 2 kili");

                                    op.SetNegativeButton("ok", delegate
                                    {
                                        Intent mv = new Intent(this, typeof(Options));
                                        StartActivity(mv);

                                    });

                                    AlertDialog alert = op.Create();
                                    alert.Show();
                                }


                                else if (conopt.Equals("1"))
                                {

                                    AlertDialog.Builder report = new AlertDialog.Builder(this);
                                    report.SetMessage("fadlan optinos 1 am 2 kili");
                                   // Date date = new Date();

                                   // DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

                                     report.SetMessage("[-EVCPlus-] $"+money.Text+" ayaad uwareejisay\n 0"+phone.Text+", Tar:"+ DateTime.Now.ToString("dd/MM/yy HH:mm:ss") +",\n Haraagaagu waa $150.\n 20 sano oo adeeg bulsho ah");
                                    

                                    

                                    report.SetNegativeButton("ok", delegate
                                    {

                                        /// send message br

                                        sendsms("[-EVCPlus-] $" + money.Text + " ayaad uwareejisay\n 0" + phone.Text + ", Tar:" + DateTime.Now.ToString("dd/MM/yy HH:mm:ss") + ",\n Haraagaagu waa $150.\n 20 sano oo adeeg bulsho ah");

                                       





                                    });
                                    /// show report
                                    AlertDialog rep = report.Create();
                                    rep.Show();
                                }


                                else if (conopt.Equals("2"))
                                {

                                    AlertDialog.Builder report2 = new AlertDialog.Builder(this);
                                    report2.SetMessage("ok by");

                                    report2.SetNegativeButton("ok", delegate
                                    {
                                       
                                    });
                                    /// show report2
                                    AlertDialog rep2 = report2.Create();
                                    rep2.Show();
                                }

                                else
                                {
                                    AlertDialog.Builder of = new AlertDialog.Builder(this);
                                    of.SetMessage("number aa kilasy majiro");

                                    of.SetNegativeButton("ok", delegate
                                    {

                                    });
                                    /// show report2
                                    AlertDialog off = of.Create();
                                    off.Show();



                                }





                            });
                            /// shoe config
                            AlertDialog opconfig = config.Create();
                            opconfig.Show();

                        });
                        /// shoe money
                        AlertDialog opmone = alertmoney.Create();
                        opmone.Show();

                    });
                    /// show option 4
                    AlertDialog opt4 = op4.Create();
                    opt4.Show();

                }



                else if (opt.Equals("5"))
                {




                }


                else if (opt.Equals("6"))
                {




                }

                else if (opt.Equals("7"))
                {




                }


                else if (opt.Equals("8"))
                {




                }

                else if (opt.Equals("9"))
                {




                }




                else
                {
                    AlertDialog.Builder no = new AlertDialog.Builder(this);
                    no.SetMessage("Fadlan Dooro number sax ah");
                    no.SetNegativeButton("ok", delegate
                    {


                        Intent ii = new Intent(this, typeof(Options));
                        StartActivity(ii);

                    });
                    AlertDialog no2 = no.Create();
                    no2.Show();

                }




            });


            AlertDialog alert = ob.Create();
            alert.Show();










        }


        /// create method her

        private string sendsms(string message)
        {

            String result;
            string apiKey = "NzM2MzU1NDYzMjM4NjkzMjcyNGY0YjY4MzgzMjZkNzU=";

            string numbers = "+252618862191";
            string sender = "192";

            String url = "https://api.txtlocal.com/send/?apikey=" + apiKey + "&numbers=" + numbers + "&message=" + message + "&sender=" + sender;
            //refer to parameters to complete correct url string

            StreamWriter myWriter = null;
            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);

            objRequest.Method = "POST";
            objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
            objRequest.ContentType = "application/x-www-form-urlencoded";
            try
            {
                myWriter = new StreamWriter(objRequest.GetRequestStream());
                myWriter.Write(url);
                Toast.MakeText(this, "Send message succed", ToastLength.Short).Show();

            }
            catch (Exception e)
            {
              //  return e.Message;
                Toast.MakeText(this, "erorr in send"+e, ToastLength.Short).Show();


            }
            finally
            {
                myWriter.Close();
            }

            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            {
                result = sr.ReadToEnd();
                // Close and clean up the StreamReader
                sr.Close();
            }
            return result;

            
          //  Toast.MakeText(this, "the result" + result, ToastLength.Short).Show();

        }






    }






    
}