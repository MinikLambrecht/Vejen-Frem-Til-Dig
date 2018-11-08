using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VejenFremTilDig.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddContactPage : ContentPage
	{
        private Entry entryName;
        private Entry entryNumber;

        public AddContactPage ()
		{
			InitializeComponent ();
		}

        async void OnAddContactClicked (object sender, EventArgs e)
        {
            entryName = this.FindByName<Entry>("entry_Name");
            entryNumber = this.FindByName<Entry>("entry_Number");

            var name = entryName.Text;
            var number = Int32.Parse(entryNumber.Text);

            ContactsPage contactPage = new ContactsPage();

            await Navigation.PushAsync(contactPage);
            contactPage.AddContact(name, number);
        }
	}
}