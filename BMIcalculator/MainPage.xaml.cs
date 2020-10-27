using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMIcalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int count = 0;
        void Handle_Submit(object sender, System.EventArgs e)
        {
            count++;
            var weightF = double.Parse(weight.Text);
            var feetNum = double.Parse(feet.Text);
            var inchNum = double.Parse(inches.Text);

            var kilograms = weightF / 2.20462;
            var ftmeters = feetNum * 0.3048;
            var inMeters = inchNum * 0.0254;
            var meters = ftmeters + inMeters;
            var msquared = meters * meters;
            var BMI = kilograms / msquared;

            BMIout.Text = $"Your BMI is {BMI}";
            //((Button)sender).Text = $"You clicked {count} times.";
        }
    }
}
