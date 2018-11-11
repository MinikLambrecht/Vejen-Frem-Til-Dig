using System;
using System.Collections.ObjectModel;
using VejenFremTilDig.Models;

namespace VejenFremTilDig.Services
{
    public class MessageListViewModel : BaseViewModel
    {
        public ObservableCollection<Message> Messages { get; set; }

        public MessageListViewModel()
        {
            Messages = new ObservableCollection<Message>()
            {
                new Message
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Lone",
                    Msg = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                },
                new Message
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Rasmus",
                    Msg = "Nullam condimentum luctus ipsum, hendrerit gravida leo blandit a."
                },
                new Message
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "IB",
                    Msg = "In hac habitasse platea dictumst. Etiam at dapibus turpis. "
                }
            };
        }
    }
}
