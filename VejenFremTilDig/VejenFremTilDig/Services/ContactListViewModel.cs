using System;
using System.Collections.ObjectModel;
using VejenFremTilDig.Models;

namespace VejenFremTilDig.Services
{
    public class ContactListViewModel : BaseViewModel
    {
        public ObservableCollection<Contact> Contacts { get; set; }

        public ContactListViewModel()
        {
            Contacts = new ObservableCollection<Contact>
            {
                new Contact
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Lone",
                    Number = 97485279
                },
                new Contact
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Bodil",
                    Number = 64558739
                },
                new Contact
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "IB",
                    Number = 81225798
                },
                new Contact
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Åse",
                    Number = 82792684
                },
                new Contact
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Rasmus",
                    Number = 10557916
                }
            };
        }

        public void AddContact(ObservableCollection<Contact> contacts)
        {
            Contact contact = new Contact { Id = Guid.NewGuid().ToString(), Name = "Bob", Number = 76889452 };
            contacts.Add(contact);
        }
    }
}
