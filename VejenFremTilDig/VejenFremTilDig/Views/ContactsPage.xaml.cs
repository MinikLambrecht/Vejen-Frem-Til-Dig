using System;
using System.Collections.Generic;
using VejenFremTilDig.Models;
using VejenFremTilDig.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VejenFremTilDig.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        ContactListViewModel ListviewModel;

        public ContactsPage()
        {
            InitializeComponent();

            ListviewModel = new ContactListViewModel();
            BindingContext = ListviewModel;
        }

        public void OnAddClick(object sender, EventArgs e)
        {
            DisplayAlert("Tapped!", "You have tapped the image!", "OK");
        }
    }
}