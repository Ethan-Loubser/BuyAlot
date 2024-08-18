using BuyAlot.Models;
using BuyAlot.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BuyAlot.ViewModels
{
    public class SearchPageViewModel : BaseProductViewModel
    {
        #region CRUD Init
        public Command ProductTappedEdit { get; }
        public Command LoadSearchProdCommand { get; }
        public ObservableCollection<Product> ProductDetails { get; }
        public ObservableCollection<Product> Products { get; }
        public Command ProductTapped { get; }
        #endregion

        public SearchPageViewModel(INavigation _navigation)
        {
            #region CRUD Con
            LoadSearchProdCommand = new Command(async () => await ExecuteLoadProductCommand());
            Products = new ObservableCollection<Product>();
            ProductDetails = new ObservableCollection<Product>();
            ProductTappedEdit = new Command<Product>(OnEditProduct);
            ProductTapped = new Command<Product>(OnProductTapped);
            Navigation = _navigation;
            #endregion
        }

        public async void OnAppearing()
        {
            await ExecuteLoadProductCommand();
            IsBusy = true;
        }

        #region CRUD Func
        async Task ExecuteLoadProductCommand()
        {
            try
            {
                Products.Clear();
                string Search = (String)Application.Current.Properties["SearchProd"];
                var prodList = await App.ProductService.GetSearchProdAsync(Search);
                foreach (var prod in prodList)
                {
                    Products.Add(prod);
                }
                IsBusy = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                IsBusy = false;
            }
        }
        private async void OnProductTapped(Product prod)
        {
            try
            {
                int SelectedProd = prod.ProdId;

                var ProdDetails = await App.ProductService.GetSelectProdAsync(SelectedProd);

                foreach (var item in ProdDetails)
                {
                    ProductDetails.Add(item);
                }

                Application.Current.Properties["CProdID"] = prod.ProdId;
                Application.Current.Properties["CProdName"] = prod.ProdName;
                Application.Current.Properties["CProdPrice"] = prod.ProdPrice;
                Application.Current.Properties["CProdImg"] = prod.ProdImg;
                Application.Current.Properties["CProdBrand"] = prod.ProdBrand;

                Routing.RegisterRoute("//ProdDetPage", typeof(ProdDetPage));
                await Shell.Current.GoToAsync($"//{nameof(ProdDetPage)}");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                IsBusy = false;
            }
        }
        private async void OnEditProduct(Product prod)
        {
            await Navigation.PushAsync(new AddProductPage(prod));
        }
        #endregion
    }
}
