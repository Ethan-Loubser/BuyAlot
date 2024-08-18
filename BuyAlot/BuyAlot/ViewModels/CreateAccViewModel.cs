using BuyAlot.Models;
using BuyAlot.Services;
using BuyAlot.Views;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Linq;

namespace BuyAlot.ViewModels
{
    public class CreateAccViewModel : BaseAccountViewModel
    {
        public Command CABackCommand { get; }
        public Command CreateAccountCommand { get; }

        public CreateAccViewModel()
        {
            CABackCommand = new Command(CABackClicked);
            CreateAccountCommand = new Command(OnCreate);
            this.PropertyChanged += (_, __) => CreateAccountCommand.ChangeCanExecute();
            Account = new Account();
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        private async void CABackClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
        private async void OnCreate(object obj)
        {
            IsBusy = true;
            try
            {
                var EmailList = await App.AccountService.GetEmailsAsync(Account.Email);
                var account = Account;

                #region AccCreationValidation
                if (account.Fname == null)
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Please enter your first name", "Ok");
                }
                else if (account.Lname == null)
                     {
                        await App.Current.MainPage.DisplayAlert("Error", "Please enter your last name", "Ok");
                     }
                else if (account.Email == null)
                     {
                        await App.Current.MainPage.DisplayAlert("Error", "Please enter your email address", "Ok");
                     }
                else if (!account.Email.Contains("@gmail.com"))
                     {
                        await App.Current.MainPage.DisplayAlert("Error", "Invalid email address, please use @gmail.com", "Ok");
                     }
                else if (account.Pword == null)
                     {
                        await App.Current.MainPage.DisplayAlert("Error", "Please enter your password", "Ok");
                     }
                else if (account.Pword.Length != 6)
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Password must have at least 6 characters", "Ok");
                }
                else if (account.PhoneNum == null)
                     {
                        await App.Current.MainPage.DisplayAlert("Error", "Please enter your phone number", "Ok");
                     }
                else if (account.Address == null)
                     {
                        await App.Current.MainPage.DisplayAlert("Error", "Please enter your home address", "Ok");
                     }
                #endregion

                if (EmailList.Count() == 0)
                {
                    await App.AccountService.AddAccAsync(account);
                    await App.Current.MainPage.DisplayAlert("Successful", "Account creation successful!", "Ok");
                    await Shell.Current.GoToAsync("..");
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Warning", "Email already in use!", "Ok");
                }
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Warning", ex.Message, "Ok");
            }
            finally
            {
                IsBusy = false;
            }

        }
    }
}
