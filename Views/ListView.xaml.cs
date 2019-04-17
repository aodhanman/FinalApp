using FinalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListView : ContentPage
	{
		public ListView ()
		{
			InitializeComponent ();
            BindingContext = new ListViewModel(Navigation);

        }
    }
}