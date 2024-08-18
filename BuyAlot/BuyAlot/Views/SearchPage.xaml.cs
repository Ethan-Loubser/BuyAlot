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
	public partial class SearchPage : ContentPage
	{
        SearchPageViewModel searchPageViewModel;
        public SearchPage ()
		{
			InitializeComponent ();
            BindingContext = searchPageViewModel = new SearchPageViewModel(Navigation);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            searchPageViewModel.OnAppearing();
        }

        private void SearchBar1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string search = SearchBar1.Text;
            Application.Current.Properties["SearchProd"] = search;
            searchPageViewModel.OnAppearing();
        }
    }
}