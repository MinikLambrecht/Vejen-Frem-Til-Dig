﻿using System;
using VejenFremTilDig.Models;
using VejenFremTilDig.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VejenFremTilDig.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        private ContactListViewModel ListviewModel;
        private int SelectedItemIndex;

        private bool firstLaunch = true;

        private string _Guid { get; set; }
        private string Name { get; set; }
        private int Number { get; set; }

        public ContactsPage()
        {
            InitializeComponent();

            firstLaunch = ((bool)Application.Current.Properties["firstLaunch"]);
            ListviewModel = new ContactListViewModel();
            BindingContext = ListviewModel;
        }

        protected override void OnAppearing()
        {
            if (firstLaunch == true)
            {
                firstLaunch = false;
                Application.Current.Properties["firstLaunch"] = firstLaunch;
                DisplayAlert("Test", "First time!", "OK");
            }
            else
            {
                DisplayAlert("Test", "Not First Time!", "Ok");
            }
        }

        protected override void OnDisappearing()
        {
            Application.Current.Properties["Contacts"] = ListviewModel;
            Application.Current.SavePropertiesAsync();
        }

        private void OnCallClicked(object sender, EventArgs e)
        {
            
        }

        async void OnAddClicked(object sender, EventArgs e)
        {
            AddContactPage addContactPage = new AddContactPage();
            await Navigation.PushAsync(addContactPage);
        }

        public void AddContact(string name, int number)
        {
            Contact contact = new Contact { Id = Guid.NewGuid().ToString(), Name = name, Number = number };
            ListviewModel.AddContact(contact);
        }

        private void OnRemoveClicked(object sender, EventArgs e)
        {
            ListviewModel.RemoveContact(SelectedItemIndex);
        }

        async void OnEditClicked(object sender, EventArgs e)
        {
            EditContactPage editContactPage = new EditContactPage();
            ListviewModel.RemoveContact(SelectedItemIndex);
            await Navigation.PushAsync(editContactPage);
            editContactPage.GetInfo(SelectedItemIndex ,_Guid, Name, Number);
        }

        public void EditContact(int index, string guid, string name, int number)
        {
            Contact contact = new Contact() { Id = guid, Name = name, Number = number };
            ListviewModel.UpdateContact(index, contact);
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            SelectedItemIndex = ListviewModel.GetSelectedContactIndex((Contact)e.Item);

            Contact contact = (Contact)e.Item;
            _Guid = contact.Id;
            Name = contact.Name;
            Number = contact.Number;
        }
    }
}