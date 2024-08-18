using BuyAlot.Models;
using BuyAlot.Services;
using BuyAlot.Views;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace BuyAlot.ViewModels
{
    public class AddProductViewModel : BaseProductViewModel
    {
        public Command SaveCommand { get; }

        public AddProductViewModel() 
        {
            SaveCommand = new Command(OnSave);

            this.PropertyChanged += (_, __) => SaveCommand.ChangeCanExecute();

            Product = new Product();
        }

        private async void OnSave()
        {
            var product = Product;
            await App.ProductService.AddProductAsync(product);

            await App.Current.MainPage.DisplayAlert("Successful", "Product has been added successfully!", "Ok");

            await Shell.Current.GoToAsync("..");
        }
    }
}
