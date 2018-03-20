using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace TipCalculator
{
    [Activity(Label = "TipCalculator", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        EditText inputBill;
        EditText inputTipPercent;
        Button calculateButton;
        TextView outputTip;
        TextView outputTotal;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            
            inputBill = FindViewById<EditText>(Resource.Id.inputBill);
            inputTipPercent = FindViewById<EditText>(Resource.Id.inputTipPercent);
            calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            outputTip = FindViewById<TextView>(Resource.Id.outputTip);
            outputTotal = FindViewById<TextView>(Resource.Id.outputTotal);

            calculateButton.Click += OnCalculateClick;
        }

        private void OnCalculateClick(object sender, EventArgs e)
        {
            string text = inputBill.Text;
            string TipPercent = inputTipPercent.Text;
            double bill;
            double tip;

            if (double.TryParse(text,out bill) && double.TryParse(TipPercent,out tip))
            {
                double tipAmount = bill * tip;
                double total = bill + tipAmount;

                outputTip.Text = tipAmount.ToString("C");
                outputTotal.Text = total.ToString("C");
            }

        }
    }
}

