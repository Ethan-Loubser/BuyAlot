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
	public partial class CategoriesPage : ContentPage
	{
		public CategoriesPage ()
		{
			InitializeComponent ();
            this.BindingContext = new CategoriesPageViewModel();
        }

        private void TechCat_Tapped(object sender, EventArgs e)
        {
            Routing.RegisterRoute("//CatProductsPage", typeof(CatProductsPage));
            Shell.Current.GoToAsync($"//{nameof(CatProductsPage)}");

            string Cat = "Tech";
            Application.Current.Properties["SelectCat"] = Cat;
        }

        #region Categories
        private void BeautyCat_Tapped(object sender, EventArgs e)
        {
            Routing.RegisterRoute("//CatProductsPage", typeof(CatProductsPage));
            Shell.Current.GoToAsync($"//{nameof(CatProductsPage)}");

            string Cat = "Beauty";
            Application.Current.Properties["SelectCat"] = Cat;
        }
        private void BooksCat_Tapped(object sender, EventArgs e)
        {
            Routing.RegisterRoute("//CatProductsPage", typeof(CatProductsPage));
            Shell.Current.GoToAsync($"//{nameof(CatProductsPage)}");

            string Cat = "Books";
            Application.Current.Properties["SelectCat"] = Cat;
        }
        private void GamingCat_Tapped(object sender, EventArgs e)
        {
            Routing.RegisterRoute("//CatProductsPage", typeof(CatProductsPage));
            Shell.Current.GoToAsync($"//{nameof(CatProductsPage)}");

            string Cat = "Gaming";
            Application.Current.Properties["SelectCat"] = Cat;
        }
        private void GardenCat_Tapped(object sender, EventArgs e)
        {
            Routing.RegisterRoute("//CatProductsPage", typeof(CatProductsPage));
            Shell.Current.GoToAsync($"//{nameof(CatProductsPage)}");

            string Cat = "Garden";
            Application.Current.Properties["SelectCat"] = Cat;
        }
        private void KitchenCat_Tapped(object sender, EventArgs e)
        {
            Routing.RegisterRoute("//CatProductsPage", typeof(CatProductsPage));
            Shell.Current.GoToAsync($"//{nameof(CatProductsPage)}");

            string Cat = "Kitchen";
            Application.Current.Properties["SelectCat"] = Cat;
        }
        private void TravelCat_Tapped(object sender, EventArgs e)
        {
            Routing.RegisterRoute("//CatProductsPage", typeof(CatProductsPage));
            Shell.Current.GoToAsync($"//{nameof(CatProductsPage)}");

            string Cat = "Travel";
            Application.Current.Properties["SelectCat"] = Cat;
        }
        private void PetsCat_Tapped(object sender, EventArgs e)
        {
            Routing.RegisterRoute("//CatProductsPage", typeof(CatProductsPage));
            Shell.Current.GoToAsync($"//{nameof(CatProductsPage)}");

            string Cat = "Pets";
            Application.Current.Properties["SelectCat"] = Cat;
        }
        private void HomeCat_Tapped(object sender, EventArgs e)
        {
            Routing.RegisterRoute("//CatProductsPage", typeof(CatProductsPage));
            Shell.Current.GoToAsync($"//{nameof(CatProductsPage)}");

            string Cat = "Home";
            Application.Current.Properties["SelectCat"] = Cat;
        }
        private void MoviesCat_Tapped(object sender, EventArgs e)
        {
            Routing.RegisterRoute("//CatProductsPage", typeof(CatProductsPage));
            Shell.Current.GoToAsync($"//{nameof(CatProductsPage)}");

            string Cat = "Movies";
            Application.Current.Properties["SelectCat"] = Cat;
        }
        #endregion
    }
}