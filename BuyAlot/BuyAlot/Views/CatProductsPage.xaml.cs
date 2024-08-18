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
	public partial class CatProductsPage : ContentPage
	{
		CatProductsViewModel catProductViewModel;
		public CatProductsPage ()
		{
			InitializeComponent ();
            BindingContext = catProductViewModel=new CatProductsViewModel(Navigation);
        }

		protected override void OnAppearing()
		{
			base.OnAppearing();
			catProductViewModel.OnAppearing();
		}
    }
}