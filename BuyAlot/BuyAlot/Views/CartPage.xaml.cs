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
    public partial class CartPage : ContentPage
    {
        CartViewModel cartViewModel;
        public CartPage()
        {
            InitializeComponent();
            BindingContext = cartViewModel = new CartViewModel(Navigation);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            cartViewModel.OnAppearing();
        }
    }
}