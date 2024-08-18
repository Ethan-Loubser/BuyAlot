using BuyAlot.Services;
using BuyAlot.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BuyAlot
{
    public partial class App : Application
    {
        static ProductService _ProductService;

        static AccountService _AccountService;

        static CartService _CartService;
        //public static int LoggedID { get; set; }
        //public static string LoggedFname { get; set; }
        //public static string LoggedLname { get; set; }
        public static ProductService ProductService
        {
            get
            {
                if (_ProductService == null)
                {
                    _ProductService = new ProductService(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Product.db3"));
                }
                return _ProductService;
            }
        }

        public static AccountService AccountService
        {
            get
            {
                if (_AccountService == null)
                {
                    _AccountService = new AccountService(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Account.db3"));
                }
                return _AccountService;
            }
        }

        public static CartService CartService
        {
            get
            {
                if (_CartService == null)
                {
                    _CartService = new CartService(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Cartt.db3"));
                }
                return _CartService;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
            //MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
