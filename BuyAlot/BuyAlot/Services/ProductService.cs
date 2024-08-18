using BuyAlot.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BuyAlot.Services
{
    public class ProductService : IProductRepository
    {
        public SQLiteAsyncConnection _database;
        public ProductService(string dbPath) 
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Product>().Wait();
        }
        #region CRUD
        //Insert & Update
        public async Task<bool> AddProductAsync(Product product)
        {
            if (product.ProdId > 0)
            {
                await _database.UpdateAsync(product);
            }
            else
            {
                await _database.InsertAsync(product);
            }
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteProductAsync(int prodID)
        {
            await _database.DeleteAsync<Product>(prodID);
            return await Task.FromResult(true);
        }

        public async Task<Product> GetProductAsync(int prodID)
        {
            return await _database.Table<Product>().Where(p=> p.ProdId==prodID).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsAsync(string SelectCat)
        {
            return await Task.FromResult(await _database.Table<Product>().Where(p => p.ProdType == SelectCat).ToListAsync());
        }

        public async Task<IEnumerable<Product>> GetSearchProdAsync(string Search)
        {
            return await Task.FromResult(await _database.Table<Product>().Where(p => p.ProdName.Contains(Search)).ToListAsync());
        }

        public Task<bool> UpdateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetSelectProdAsync(int SelectedProd)
        {
            return await Task.FromResult(await _database.Table<Product>().Where(p => p.ProdId == SelectedProd).ToListAsync());
        }

        public async Task<Product> GetProdDetAsync(string ProdName)
        {
            return await Task.FromResult(await _database.Table<Product>().Where(p => p.ProdName == ProdName).FirstOrDefaultAsync());
        }
        #endregion
    }
}
