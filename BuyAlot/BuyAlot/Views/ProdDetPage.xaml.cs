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
    public partial class ProdDetPage : ContentPage
    {
        ProdDetailViewModel prodDetailViewModel;
        public ProdDetPage()
        {
            InitializeComponent();
            BindingContext = prodDetailViewModel = new ProdDetailViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var ProdID = (int)Application.Current.Properties["CProdID"];
            var ProdImg = $"{Application.Current.Properties["CProdImg"]}";
            var ProdName = $"{(string)Application.Current.Properties["CProdName"]}";
            var ProdBrand = $"{(string)Application.Current.Properties["CProdBrand"]}";
            var ProdPrice = $"{(string)Application.Current.Properties["CProdPrice"]}";

            if (ProdID == 0)
            {
                Navigation.PushAsync(new CatProductsPage());
            }
            else
            {
                ImgProd.Source = $"{ProdImg}";
                lblProdName.Text = $"{ProdName}";
                lblProdBrand.Text = $"{ProdBrand}";
                lblProdPrice.Text = $"R{ProdPrice}";
            }
            prodDetailViewModel.OnAppearing();
        }
    }
}