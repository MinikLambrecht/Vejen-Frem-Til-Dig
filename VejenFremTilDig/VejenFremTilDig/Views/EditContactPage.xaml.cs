using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VejenFremTilDig.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditContactPage : ContentPage
	{
        private Entry entryName;
        private Entry entryNumber;

        private int Index { get; set; }
        private string _Guid { get; set; }

		public EditContactPage ()
		{
			InitializeComponent ();
		}

        public void GetInfo(int index, string guid, string name, string number)
        {
            entryEdit_Name.Text = name;
            entryEdit_Number.Text = number.ToString();
            Index = index;
            _Guid = guid;
        }

        async void OnEditContactClicked(object sender, EventArgs e)
        {
            entryName = this.FindByName<Entry>("entryEdit_Name");
            entryNumber = this.FindByName<Entry>("entryEdit_Number");

            var name = entryName.Text;
            var number = entryNumber.Text;

            ContactsPage contactsPage = new ContactsPage();
            await Navigation.PushAsync(contactsPage);
            contactsPage.EditContact(Index - 1, _Guid, name, number);
        }
	}
}