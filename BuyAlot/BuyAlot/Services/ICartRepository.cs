using BuyAlot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuyAlot.Services
{
    internal interface ICartRepository
    {
        #region CRUD
        Task<bool> Add2Cart(Cartt cart);
        Task<IEnumerable<Cartt>> GetCartProdsAsync (int LoggedID);
        Task<bool> DeleteCProductAsync(int CartId);
        #endregion
    }
}
