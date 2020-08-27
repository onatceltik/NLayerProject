using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayerProject.Core.Models;

namespace UdemyNLayerProject.Core.Repository
{
    internal interface IProductRepository
    {
        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}
