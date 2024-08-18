using BuyAlot.Views;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BuyAlot.ViewModels
{
    public class HubViewModel
    {
        public Command toAddProductPage { get; }
        public Command toProductHubPage { get; }
        public Command toCartPage { get; }
        
        public HubViewModel()
        {
            toAddProductPage = new Command(onAddProductClicked);
            toProductHubPage = new Command(onViewProductsClicked);
            toCartPage = new Command(onCartClicked);
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        private async void onAddProductClicked(object obj)
        {
            Routing.RegisterRoute("//AddProductPage", typeof(AddProductPage));
            await Shell.Current.GoToAsync($"//{nameof(AddProductPage)}");
        }

        private async void onViewProductsClicked(object obj)
        {
            Routing.RegisterRoute("//ProductHub", typeof(ProductHub));
            await Shell.Current.GoToAsync($"//{nameof(ProductHub)}");
        }

        private async void onCartClicked(object obj)
        {
            Routing.RegisterRoute("//CartPage", typeof(CartPage));
            await Shell.Current.GoToAsync($"//{nameof(CartPage)}");
        }

        public ICommand OpenWebCommand { get; }
    }
}