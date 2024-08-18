using BuyAlot.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BuyAlot.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductHub : ContentPage
	{
		public ProductHub ()
		{
			InitializeComponent ();
            this.BindingContext = new ProductHubViewModel();
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            Application.Current.Properties["SearchProd"] = SearchBar1.Text;

            Routing.RegisterRoute("//SearchPage", typeof(SearchPage));
            Shell.Current.GoToAsync($"//{nameof(SearchPage)}");
        }
    }
}