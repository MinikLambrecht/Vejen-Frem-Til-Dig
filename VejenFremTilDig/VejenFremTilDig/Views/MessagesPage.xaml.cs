using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VejenFremTilDig.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VejenFremTilDig.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MessagesPage : ContentPage
	{
        public MessageListViewModel ListViewModel;

		public MessagesPage ()
		{
			InitializeComponent ();

            ListViewModel = new MessageListViewModel();
            BindingContext = ListViewModel;            
		}
	}
}