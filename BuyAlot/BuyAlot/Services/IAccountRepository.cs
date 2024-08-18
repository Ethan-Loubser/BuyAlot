using BuyAlot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuyAlot.Services
{
    internal interface IAccountRepository
    {
        #region CRUD
        Task<bool> AddAccAsync(Account account);
        Task<IEnumerable<Account>> GetEmailsAsync(string Email);
        Task<Account> LogInValidAsync(string Email, string Pword);
        Task<Account> FetchAccDetailsAsync(string AccEmail);
        #endregion
    }
}
