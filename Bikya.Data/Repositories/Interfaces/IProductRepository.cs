﻿using Bikya.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bikya.Data.Repositories.Interfaces
{
    public interface IProductRepository:IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsByCategoryAsync(Category category);


        Task<IEnumerable<Product>> GetProductsByUserAsync(int userId);


        Task<IEnumerable<Product>> GetProductsWithImages();

        Task<Product> GetProductWithImagesByIdAsync(int id);
        Task<bool> GetSameProductSameUserAsync(int userId, string title);


    }
}
