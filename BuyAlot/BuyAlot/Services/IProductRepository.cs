using BuyAlot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuyAlot.Services
{
    internal interface IProductRepository
    {
        #region CRUD
        Task<bool> AddProductAsync(Product product);
        Task<bool> UpdateProductAsync(Product product);
        Task<bool> DeleteProductAsync(int ProdID);
        Task<Product> GetProductAsync(int ProdID);
        Task<IEnumerable<Product>> GetProductsAsync(string SelectCat);
        Task<IEnumerable<Product>> GetSearchProdAsync(string Search);
        Task<IEnumerable<Product>> GetSelectProdAsync(int SelectedProd);
        Task<Product> GetProdDetAsync(string ProdName);
        #endregion
    }
}
