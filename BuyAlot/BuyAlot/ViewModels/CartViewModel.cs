using BuyAlot.Models;
using BuyAlot.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BuyAlot.ViewModels
{
    public class CartViewModel : BaseCartViewModel
    {
        public Command LoadCartCommand { get; }
        public ObservableCollection<Cartt> CartProds { get; }
        public Command CProdTappedDelete { get; }

        public CartViewModel(INavigation _navigation) 
        {
            LoadCartCommand = new Command(async () => await ExecuteLoadCartCommand());
            CartProds = new ObservableCollection<Cartt>();
            CProdTappedDelete = new Command<Cartt>(OnDelete);
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        async Task ExecuteLoadCartCommand()
        {
            var LoggedID = (int)Application.Current.Properties["LoggedID"];
            IsBusy = true;
            try
            {
                CartProds.Clear();
                var prodList = await App.CartService.GetCartProdsAsync(LoggedID);
                foreach (var prod in prodList)
                {
                    CartProds.Add(prod);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                IsBusy = false;
            }
        }
        private async void OnDelete(Cartt cart)
        {
            int CartId = cart.CartId;
            if (cart == null)
            {
                return;
            }

            await App.CartService.DeleteCProductAsync(cart.CartId);
            await ExecuteLoadCartCommand();
        }
    }
}
