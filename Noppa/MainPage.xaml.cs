using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Noppa
{
    public partial class MainPage : ContentPage
    {
        Random rnd = new Random();
        string setting = "6";

        public MainPage()
        {
            InitializeComponent();
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (setting == "6")
            {
                numeroLabel.Text = rnd.Next(1, 7).ToString();
            }
            else
            {
                numeroLabel.Text = rnd.Next(1, 13).ToString();
            }
        }

        private void btn6_Clicked(object sender, EventArgs e)
        {
            setting = "6";
            btn12.BackgroundColor = Color.White;
            btn6.BackgroundColor = Color.LightGreen;
        }

        private void btn12_Clicked(object sender, EventArgs e)
        {
            setting = "12";
            btn12.BackgroundColor = Color.LightGreen;
            btn6.BackgroundColor = Color.White;
        }
    }
}
