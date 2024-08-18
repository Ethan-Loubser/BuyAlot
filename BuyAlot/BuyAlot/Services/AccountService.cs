using BuyAlot.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace BuyAlot.Services
{
    public class AccountService : IAccountRepository
    {
        public SQLiteAsyncConnection _database;
        public AccountService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Account>().Wait();
        }
        #region CRUD
        //Insert & Update
        public async Task<bool> AddAccAsync(Account account)
        {
            await _database.InsertAsync(account);
            return await Task.FromResult(true);
        }
        public async Task<IEnumerable<Account>> GetEmailsAsync(string IEmail)
        {
            return await Task.FromResult(await _database.Table<Account>().Where(a => a.Email == IEmail).ToListAsync());
        }
        public async Task<Account> LogInValidAsync(string IEmail, string IPword)
        {
            return await Task.FromResult(await _database.Table<Account>().Where(a => a.Pword == IPword).Where(a => a.Email == IEmail).FirstOrDefaultAsync());
        }
        public async Task<Account> FetchAccDetailsAsync(string AccEmail)
        {
            //return await _database.QueryAsync<Account>().Where(a => a.Email == AccEmail).FirstOrDefaultAsync();
            return await _database.Table<Account>().Where(p => p.Email == AccEmail).FirstOrDefaultAsync();
        }
        #endregion
    }
}
