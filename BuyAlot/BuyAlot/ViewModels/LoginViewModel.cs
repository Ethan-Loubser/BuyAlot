using BuyAlot.Views;
using BuyAlot.Services;
using BuyAlot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Windows;
using System.Linq;
using System.Collections;

namespace BuyAlot.ViewModels
{
    public class LoginViewModel : BaseAccountViewModel
    {
        public Command LoginCommand { get; }
        public Command CreateCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            CreateCommand = new Command(OnCreateClicked);
            Account = new Account();
        }
        public void OnAppearing()
        {
            IsBusy = true;
        }

        private async void OnLoginClicked(object obj)
        {
            IsBusy = true;
            try
            {
                var AccEmail = await App.AccountService.LogInValidAsync(Account.Email, Account.Pword);

                if (AccEmail == null)
                {
                    await App.Current.MainPage.DisplayAlert("Warning", "Email or Password incorrect!", "Ok");
                }
                else
                {
                    Application.Current.Properties["LoggedID"] = AccEmail.AccID;
                    Application.Current.Properties["LoggedFname"] = AccEmail.Fname;
                    Application.Current.Properties["LoggedLname"] = AccEmail.Lname;

                    await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
                }
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("BABA", ex.Message, "Ok");
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async void OnCreateClicked(object obj)
        {
            Routing.RegisterRoute("//CreateAccPage", typeof(CreateAccPage));
            await Shell.Current.GoToAsync($"//{nameof(CreateAccPage)}");
        }
    }
}
