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
    public class CatProductsViewModel : BaseProductViewModel
    {
        #region CRUD Init
        public Command LoadProductCommand { get; }
        public ObservableCollection<Product> Products { get; }
        public ObservableCollection<Product> ProductDetails { get; }
        public Command AddProductCommand { get; }
        public Command ProductTappedEdit { get; }
        public Command ProductTappedDelete { get; }
        public Command ProductTapped { get; }
        #endregion
        public CatProductsViewModel(INavigation _navigation)
        {
            #region CRUD Con
            LoadProductCommand = new Command(async () => await ExecuteLoadProductCommand());
            Products= new ObservableCollection<Product>();
            ProductDetails = new ObservableCollection<Product>();
            AddProductCommand = new Command(OnAddProduct);
            ProductTappedEdit = new Command<Product>(OnEditProduct);
            ProductTappedDelete = new Command<Product>(OnDeleteProduct);
            ProductTapped = new Command<Product>(OnProductTapped);
            Navigation = _navigation;
            #endregion
        }
        #region CRUD Func
        async Task ExecuteLoadProductCommand()
        {
            //IsBusy = true;
            try
            {
                Products.Clear();
                string SelectCat = (String)Application.Current.Properties["SelectCat"];
                var prodList = await App.ProductService.GetProductsAsync(SelectCat);
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
        public async void OnAppearing()
        {
            await ExecuteLoadProductCommand();
            IsBusy = true;
        }
        private async void OnAddProduct(object obj)
        {
            Routing.RegisterRoute("//AddProductPage", typeof(AddProductPage));
            await Shell.Current.GoToAsync($"//{nameof(AddProductPage)}");
        }
        private async void OnEditProduct(Product prod)
        {
            await Navigation.PushAsync(new AddProductPage(prod));
        }
        private async void OnDeleteProduct(Product prod)
        {
            if (prod == null)
            {
                return;
            }

            await App.ProductService.DeleteProductAsync(prod.ProdId);
            await ExecuteLoadProductCommand();
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
            catch(Exception ex)
            {

            }
            finally
            {
                IsBusy = false;
            }
        }
        #endregion
    }
}
