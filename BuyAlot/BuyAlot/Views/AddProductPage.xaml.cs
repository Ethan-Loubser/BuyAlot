using BuyAlot.Models;
using BuyAlot.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BuyAlot.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddProductPage : ContentPage
	{
		public Product Product { get; set; }
		public AddProductPage ()
		{
			InitializeComponent ();
			BindingContext = new AddProductViewModel();
        }

        public AddProductPage(Product product)
        {
            InitializeComponent();
            BindingContext = new AddProductViewModel();

			if (product != null ) 
			{
				((AddProductViewModel)BindingContext).Product = product;
			}
        }
    }
}