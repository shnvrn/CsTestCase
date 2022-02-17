﻿using Basket.API.Entities;
using System.Threading.Tasks;

namespace Basket.API.Repositories
{
    public interface IBasketRepository
    {
        Task<ShoppingBasket> GetBasket(string userName);
        Task<ShoppingBasket> AddBasket(ShoppingBasket basket);
        Task DeleteBasket(string userName);
    }
}
