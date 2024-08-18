using BuyAlot.ViewModels;
using BuyAlot.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace BuyAlot
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CatProductsPage), typeof(CatProductsPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
