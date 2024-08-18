using BuyAlot.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuyAlot.Services
{
    public class CartService : ICartRepository
    {
        public SQLiteAsyncConnection _database;
        public CartService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Cartt>().Wait();
        }
        #region CRUD
        public async Task<IEnumerable<Cartt>> GetCartProdsAsync(int LoggedID)
        {
        return await Task.FromResult(await _database.Table<Cartt>().Where(a => a.FAccID == LoggedID).ToListAsync());
        }
        public async Task<bool> Add2Cart(Cartt cart)
        {
            await _database.InsertAsync(cart);
            return await Task.FromResult(true);
        }
        public async Task<bool> DeleteCProductAsync(int CartId)
        {
            await _database.DeleteAsync<Cartt>(CartId);
            return await Task.FromResult(true);
        }
        #endregion
    }
}
