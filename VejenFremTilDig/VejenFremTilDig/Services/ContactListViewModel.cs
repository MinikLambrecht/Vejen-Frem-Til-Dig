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

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        public ObservableCollection<Contact> getContacts()
        {
            return Contacts;
        }

        public void RemoveContact(int index)
        {
            Contacts.RemoveAt(index);
        }

        public void UpdateContact(int index, Contact contact)
        {
            Contacts.Insert(index, contact);
        }

        public int GetSelectedContactIndex(Contact contact)
        {
            int index = Contacts.IndexOf(contact);

            return index;
        }
    }
}
