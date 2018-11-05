using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VejenFremTilDig.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn_Calls_Tapped(object sender, EventArgs e)
        {
            
        }

        private void Btn_Videos_Tapped(object sender, EventArgs e)
        {

        }

        private void Btn_Messages_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Tap gesture reconganised", "OK");
        }
    }
}