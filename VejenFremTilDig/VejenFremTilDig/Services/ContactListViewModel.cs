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
            Contacts = new ObservableCollection<Contact>()
            {
                new Contact()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Lone",
                    Number = "79845582"
                },
                new Contact()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Bodil",
                    Number = "94865579"
                },
                new Contact()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "IB",
                    Number = "94887628"
                },
                new Contact()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Åse",
                    Number = "46795813"
                },
                new Contact()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Rasmus",
                    Number = "94678542"
                }
            };
        }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        public ObservableCollection<Contact> GetContacts()
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
