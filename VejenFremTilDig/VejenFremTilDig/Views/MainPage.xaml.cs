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

        async void Btn_Calls_Tapped(object sender, EventArgs e)
        {
            ContactsPage contactsPage = new ContactsPage();
            await Navigation.PushAsync(contactsPage);
        }

        async void Btn_Videos_Tapped(object sender, EventArgs e)
        {
            VideoPage videoPage = new VideoPage();
            await Navigation.PushAsync(videoPage);
        }

        async void Btn_Messages_Tapped(object sender, EventArgs e)
        {
            MessagesPage messagesPage = new MessagesPage();
            await Navigation.PushAsync(messagesPage);
        }
    }
}