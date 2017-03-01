using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using CurrencyConverter.Models;
using System;

namespace CurrencyConverter
{
    [Activity(Label = "CurrencyConverter", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        

        public List<Converter> otherValues { get; set; }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            // list of countries in relationships to the USD

            otherValues = new List<Converter>();
            otherValues.Add(new Converter {Country = "CAD", valueInUSD = 1.31 });
            otherValues.Add(new Converter { Country = "GBP", valueInUSD = 0.92 });
            otherValues.Add(new Converter { Country = "EUR", valueInUSD = 0.54 });

            Spinner spinner1 = FindViewById<Spinner>(Resource.Id.Spinner1);
            spinner1.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected); 

            var adapter = ArrayAdapter.CreateFromResource(
                this, Resource.Array.selectCurrency, Android.Resource.Layout.SimpleSpinnerDropDownItem);
              spinner1.Adapter = adapter;

            Spinner spinner2 = FindViewById<Spinner>(Resource.Id.Spinner2);
            spinner2.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);

            var adapter2 = ArrayAdapter.CreateFromResource(
                this, Resource.Array.selectCurrency, Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner2.Adapter = adapter;
            

        }

        private void Spinner2_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner2 = (Spinner)sender;

            
            throw new NotImplementedException();
        }

        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner1 = (Spinner)sender;

           
            


            

           
        }

      
        
        }


    }




