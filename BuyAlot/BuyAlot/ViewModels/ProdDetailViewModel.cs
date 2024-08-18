using System;
using BuyAlot.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using BuyAlot.Views;

namespace BuyAlot.ViewModels
{
    public class ProdDetailViewModel : BaseCartViewModel
    {
        public Command AddToCart { get; }
        public ObservableCollection<Cartt> CartProds { get; }

        public ProdDetailViewModel()
        {
            AddToCart = new Command(OnAddToCart);
            cartProd = new Cartt();
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        private async void OnAddToCart()
        {
            try
            {
                var cart = cartProd;
                cart.FAccID = (int)Application.Current.Properties["LoggedID"];
                cart.CProdName = (string)Application.Current.Properties["CProdName"];
                cart.CProdPrice = (string)Application.Current.Properties["CProdPrice"];
                cart.CProdImg = (string)Application.Current.Properties["CProdImg"];
                cart.CProdBrand = (string)Application.Current.Properties["CProdBrand"];

                await App.CartService.Add2Cart(cart);
                await App.Current.MainPage.DisplayAlert("Successful", "Product has been added to cart!", "Ok");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
            }
        }
    }
}
