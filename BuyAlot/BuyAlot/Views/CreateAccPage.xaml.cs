using BuyAlot.ViewModels;
using BuyAlot.Models;
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
    public partial class CreateAccPage : ContentPage
    {
        public Product Product { get; set; }
        public CreateAccPage()
        {
            InitializeComponent();
            BindingContext = new CreateAccViewModel();
        }

        public CreateAccPage(Account account)
        {
            InitializeComponent();
            BindingContext = new CreateAccViewModel();

            if (account != null)
            {
                ((CreateAccViewModel)BindingContext).Account = account;
            }
        }
    }
}