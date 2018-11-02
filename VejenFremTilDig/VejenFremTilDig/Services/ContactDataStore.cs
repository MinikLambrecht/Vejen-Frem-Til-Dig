using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VejenFremTilDig.Models;

namespace VejenFremTilDig.Services
{
    public class ContactDataStore : IDataStore<Contact>
    {
        List<Contact> list;

        public ContactDataStore()
        {
            list = new List<Contact>();
            var contactsList = new List<Contact>
            {
                new Contact { Id = Guid.NewGuid().ToString(), Name = "Lone", Number = 44685975},
                new Contact { Id = Guid.NewGuid().ToString(), Name = "Bodil", Number = 86779428},
                new Contact { Id = Guid.NewGuid().ToString(), Name = "Ib", Number = 22879548},
                new Contact { Id = Guid.NewGuid().ToString(), Name = "Åse", Number = 34688951},
                new Contact { Id = Guid.NewGuid().ToString(), Name = "Rasmus", Number = 91877468}
            };

            foreach (var contact in contactsList)
            {
                list.Add(contact);
            }
        }


        public async Task<bool> AddItemAsync(Contact contact)
        {
            list.Add(contact);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Contact contact)
        {
            var oldContact = list.Where((Contact arg) => arg.Id == contact.Id).FirstOrDefault();
            list.Remove(oldContact);
            list.Add(contact);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldContact = list.Where((Contact arg) => arg.Id == id).FirstOrDefault();
            list.Remove(oldContact);

            return await Task.FromResult(true);
        }

        public async Task<Contact> GetItemAsync(string id)
        {
            return await Task.FromResult(list.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Contact>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(list);
        }
    }
}
