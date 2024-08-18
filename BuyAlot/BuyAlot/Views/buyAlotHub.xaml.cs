using BuyAlot.ViewModels;
using BuyAlot.Views;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BuyAlot.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            Application.Current.Properties["LoggedID"] = 0;
            this.BindingContext = new HubViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var LoggedID = (int)Application.Current.Properties["LoggedID"];

            if (LoggedID == 0)
            {
                Navigation.PushAsync(new LoginPage());
            }
            else
            {
                lblWelcome.Text = $"Welcome {Application.Current.Properties["LoggedFname"].ToString()} {Application.Current.Properties["LoggedLname"].ToString()}";
            }
        }
    }
}