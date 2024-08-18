using BuyAlot.Models;
using BuyAlot.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace BuyAlot.ViewModels
{
    public class ProductHubViewModel : BaseProductViewModel
    {
        public Command toCatList { get; }
        public Command ProdSearch { get; }
        #region RecProducts
        public Command prod1 { get; }
        public Command prod2 { get; }
        public Command prod3 { get; }
        public Command prod4 { get; }
        public Command prod5 { get; }
        public Command prod6 { get; }
        public Command prod7 { get; }
        public Command prod8 { get; }
        public Command prod9 { get; }
        public Command prod10 { get; }
        public Command prod11 { get; }
        public Command prod12 { get; }
        #endregion
        #region HotCategories
        public Command HotTech { get; }
        public Command HotBeauty { get; }
        public Command HotBooks { get; }
        public Command HotGaming { get; }
        #endregion
        public ObservableCollection<Product>ProdDetails { get; }

        public ProductHubViewModel()
        {
            toCatList = new Command(ViewAllCatClicked);
            #region ReccProducts
            prod1 = new Command(OnProduct1);
            prod2 = new Command(OnProduct2);
            prod3 = new Command(OnProduct3);
            prod4 = new Command(OnProduct4);
            prod5 = new Command(OnProduct5);
            prod6 = new Command(OnProduct6);
            prod7 = new Command(OnProduct7);
            prod8 = new Command(OnProduct8);
            prod9 = new Command(OnProduct9);
            prod10 = new Command(OnProduct10);
            prod11 = new Command(OnProduct11);
            prod12 = new Command(OnProduct12);
            #endregion
            #region HottCategories
            HotTech = new Command(OnHotTech);
            HotBeauty = new Command(OnHotBeauty);
            HotBooks = new Command(OnHotBooks);
            HotGaming = new Command(OnHotGaming);
            #endregion
            ProdDetails = new ObservableCollection<Product>();
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        private async void ViewAllCatClicked(object obj)
        {
            Routing.RegisterRoute("//CategoriesPage", typeof(CategoriesPage));
            await Shell.Current.GoToAsync($"//{nameof(CategoriesPage)}");
        }

        #region RecProductsFunc
        private async void OnProduct1(object obj)
        {
            IsBusy = true;
            try
            {
                string ProdName = "Samsung S21";
                var ProdDet = await App.ProductService.GetProdDetAsync(ProdName);

                Application.Current.Properties["CProdID"] = ProdDet.ProdId;
                Application.Current.Properties["CProdName"] = ProdName;
                Application.Current.Properties["CProdPrice"] = ProdDet.ProdPrice;
                Application.Current.Properties["CProdImg"] = ProdDet.ProdImg;
                Application.Current.Properties["CProdBrand"] = ProdDet.ProdBrand;

                Routing.RegisterRoute("//ProdDetPage", typeof(ProdDetPage));
                await Shell.Current.GoToAsync($"//{nameof(ProdDetPage)}");
            }
            catch(Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("BABA", ex.Message, "Ok");
            }
        }
        private async void OnProduct2(object obj)
        {
            IsBusy = true;
            try
            {
                string ProdName = "Life of Pi";
                var ProdDet = await App.ProductService.GetProdDetAsync(ProdName);

                Application.Current.Properties["CProdID"] = ProdDet.ProdId;
                Application.Current.Properties["CProdName"] = ProdName;
                Application.Current.Properties["CProdPrice"] = ProdDet.ProdPrice;
                Application.Current.Properties["CProdImg"] = ProdDet.ProdImg;
                Application.Current.Properties["CProdBrand"] = ProdDet.ProdBrand;

                Routing.RegisterRoute("//ProdDetPage", typeof(ProdDetPage));
                await Shell.Current.GoToAsync($"//{nameof(ProdDetPage)}");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("BABA", ex.Message, "Ok");
            }
        }
        private async void OnProduct3(object obj)
        {
            IsBusy = true;
            try
            {
                string ProdName = "Playstation 5";
                var ProdDet = await App.ProductService.GetProdDetAsync(ProdName);

                Application.Current.Properties["CProdID"] = ProdDet.ProdId;
                Application.Current.Properties["CProdName"] = ProdName;
                Application.Current.Properties["CProdPrice"] = ProdDet.ProdPrice;
                Application.Current.Properties["CProdImg"] = ProdDet.ProdImg;
                Application.Current.Properties["CProdBrand"] = ProdDet.ProdBrand;

                Routing.RegisterRoute("//ProdDetPage", typeof(ProdDetPage));
                await Shell.Current.GoToAsync($"//{nameof(ProdDetPage)}");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("BABA", ex.Message, "Ok");
            }
        }
        private async void OnProduct4(object obj)
        {
            IsBusy = true;
            try
            {
                string ProdName = "Playstation 5 Remote";
                var ProdDet = await App.ProductService.GetProdDetAsync(ProdName);

                Application.Current.Properties["CProdID"] = ProdDet.ProdId;
                Application.Current.Properties["CProdName"] = ProdName;
                Application.Current.Properties["CProdPrice"] = ProdDet.ProdPrice;
                Application.Current.Properties["CProdImg"] = ProdDet.ProdImg;
                Application.Current.Properties["CProdBrand"] = ProdDet.ProdBrand;

                Routing.RegisterRoute("//ProdDetPage", typeof(ProdDetPage));
                await Shell.Current.GoToAsync($"//{nameof(ProdDetPage)}");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("BABA", ex.Message, "Ok");
            }
        }
        private async void OnProduct5(object obj)
        {
            IsBusy = true;
            try
            {
                string ProdName = "Knives set";
                var ProdDet = await App.ProductService.GetProdDetAsync(ProdName);

                Application.Current.Properties["CProdID"] = ProdDet.ProdId;
                Application.Current.Properties["CProdName"] = ProdName;
                Application.Current.Properties["CProdPrice"] = ProdDet.ProdPrice;
                Application.Current.Properties["CProdImg"] = ProdDet.ProdImg;
                Application.Current.Properties["CProdBrand"] = ProdDet.ProdBrand;

                Routing.RegisterRoute("//ProdDetPage", typeof(ProdDetPage));
                await Shell.Current.GoToAsync($"//{nameof(ProdDetPage)}");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("BABA", ex.Message, "Ok");
            }
        }
        private async void OnProduct6(object obj)
        {
            IsBusy = true;
            try
            {
                string ProdName = "Make Up kit";
                var ProdDet = await App.ProductService.GetProdDetAsync(ProdName);

                Application.Current.Properties["CProdID"] = ProdDet.ProdId;
                Application.Current.Properties["CProdName"] = ProdName;
                Application.Current.Properties["CProdPrice"] = ProdDet.ProdPrice;
                Application.Current.Properties["CProdImg"] = ProdDet.ProdImg;
                Application.Current.Properties["CProdBrand"] = ProdDet.ProdBrand;

                Routing.RegisterRoute("//ProdDetPage", typeof(ProdDetPage));
                await Shell.Current.GoToAsync($"//{nameof(ProdDetPage)}");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("BABA", ex.Message, "Ok");
            }
        }
        private async void OnProduct7(object obj)
        {
            IsBusy = true;
            try
            {
                string ProdName = "Samsung Watch 4";
                var ProdDet = await App.ProductService.GetProdDetAsync(ProdName);

                Application.Current.Properties["CProdID"] = ProdDet.ProdId;
                Application.Current.Properties["CProdName"] = ProdName;
                Application.Current.Properties["CProdPrice"] = ProdDet.ProdPrice;
                Application.Current.Properties["CProdImg"] = ProdDet.ProdImg;
                Application.Current.Properties["CProdBrand"] = ProdDet.ProdBrand;

                Routing.RegisterRoute("//ProdDetPage", typeof(ProdDetPage));
                await Shell.Current.GoToAsync($"//{nameof(ProdDetPage)}");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("BABA", ex.Message, "Ok");
            }
        }
        private async void OnProduct8(object obj)
        {
            IsBusy = true;
            try
            {
                string ProdName = "GOT box set";
                var ProdDet = await App.ProductService.GetProdDetAsync(ProdName);

                Application.Current.Properties["CProdID"] = ProdDet.ProdId;
                Application.Current.Properties["CProdName"] = ProdName;
                Application.Current.Properties["CProdPrice"] = ProdDet.ProdPrice;
                Application.Current.Properties["CProdImg"] = ProdDet.ProdImg;
                Application.Current.Properties["CProdBrand"] = ProdDet.ProdBrand;

                Routing.RegisterRoute("//ProdDetPage", typeof(ProdDetPage));
                await Shell.Current.GoToAsync($"//{nameof(ProdDetPage)}");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("BABA", ex.Message, "Ok");
            }
        }
        private async void OnProduct9(object obj)
        {
            IsBusy = true;
            try
            {
                string ProdName = "Melamine cup";
                var ProdDet = await App.ProductService.GetProdDetAsync(ProdName);

                Application.Current.Properties["CProdID"] = ProdDet.ProdId;
                Application.Current.Properties["CProdName"] = ProdName;
                Application.Current.Properties["CProdPrice"] = ProdDet.ProdPrice;
                Application.Current.Properties["CProdImg"] = ProdDet.ProdImg;
                Application.Current.Properties["CProdBrand"] = ProdDet.ProdBrand;

                Routing.RegisterRoute("//ProdDetPage", typeof(ProdDetPage));
                await Shell.Current.GoToAsync($"//{nameof(ProdDetPage)}");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("BABA", ex.Message, "Ok");
            }
        }
        private async void OnProduct10(object obj)
        {
            IsBusy = true;
            try
            {
                string ProdName = "Shrek 2 (DVD)";
                var ProdDet = await App.ProductService.GetProdDetAsync(ProdName);

                Application.Current.Properties["CProdID"] = ProdDet.ProdId;
                Application.Current.Properties["CProdName"] = ProdName;
                Application.Current.Properties["CProdPrice"] = ProdDet.ProdPrice;
                Application.Current.Properties["CProdImg"] = ProdDet.ProdImg;
                Application.Current.Properties["CProdBrand"] = ProdDet.ProdBrand;

                Routing.RegisterRoute("//ProdDetPage", typeof(ProdDetPage));
                await Shell.Current.GoToAsync($"//{nameof(ProdDetPage)}");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("BABA", ex.Message, "Ok");
            }
        }
        private async void OnProduct11(object obj)
        {
            IsBusy = true;
            try
            {
                string ProdName = "Fury (DVD)";
                var ProdDet = await App.ProductService.GetProdDetAsync(ProdName);

                Application.Current.Properties["CProdID"] = ProdDet.ProdId;
                Application.Current.Properties["CProdName"] = ProdName;
                Application.Current.Properties["CProdPrice"] = ProdDet.ProdPrice;
                Application.Current.Properties["CProdImg"] = ProdDet.ProdImg;
                Application.Current.Properties["CProdBrand"] = ProdDet.ProdBrand;

                Routing.RegisterRoute("//ProdDetPage", typeof(ProdDetPage));
                await Shell.Current.GoToAsync($"//{nameof(ProdDetPage)}");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("BABA", ex.Message, "Ok");
            }
        }
        private async void OnProduct12(object obj)
        {
            IsBusy = true;
            try
            {
                string ProdName = "Painting 90x90";
                var ProdDet = await App.ProductService.GetProdDetAsync(ProdName);

                Application.Current.Properties["CProdID"] = ProdDet.ProdId;
                Application.Current.Properties["CProdName"] = ProdName;
                Application.Current.Properties["CProdPrice"] = ProdDet.ProdPrice;
                Application.Current.Properties["CProdImg"] = ProdDet.ProdImg;
                Application.Current.Properties["CProdBrand"] = ProdDet.ProdBrand;

                Routing.RegisterRoute("//ProdDetPage", typeof(ProdDetPage));
                await Shell.Current.GoToAsync($"//{nameof(ProdDetPage)}");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("BABA", ex.Message, "Ok");
            }
        }
        #endregion
        #region HotCategoriesFunc
        private async void OnHotTech(object obj)
        {
            IsBusy = true;
            try
            {
                Routing.RegisterRoute("//CatProductsPage", typeof(CatProductsPage));
                await Shell.Current.GoToAsync($"//{nameof(CatProductsPage)}");

                string Cat = "Tech";
                Application.Current.Properties["SelectCat"] = Cat;
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("BABA", ex.Message, "Ok");
            }
        }

        private async void OnHotBeauty(object obj)
        {
            IsBusy = true;
            try
            {
                Routing.RegisterRoute("//CatProductsPage", typeof(CatProductsPage));
                await Shell.Current.GoToAsync($"//{nameof(CatProductsPage)}");

                string Cat = "Beauty";
                Application.Current.Properties["SelectCat"] = Cat;
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("BABA", ex.Message, "Ok");
            }
        }

        private async void OnHotBooks(object obj)
        {
            IsBusy = true;
            try
            {
                Routing.RegisterRoute("//CatProductsPage", typeof(CatProductsPage));
                await Shell.Current.GoToAsync($"//{nameof(CatProductsPage)}");

                string Cat = "Books";
                Application.Current.Properties["SelectCat"] = Cat;
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("BABA", ex.Message, "Ok");
            }
        }

        private async void OnHotGaming(object obj)
        {
            IsBusy = true;
            try
            {
                Routing.RegisterRoute("//CatProductsPage", typeof(CatProductsPage));
                await Shell.Current.GoToAsync($"//{nameof(CatProductsPage)}");

                string Cat = "Gaming";
                Application.Current.Properties["SelectCat"] = Cat;
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("BABA", ex.Message, "Ok");
            }
        }
        #endregion
    }
}
