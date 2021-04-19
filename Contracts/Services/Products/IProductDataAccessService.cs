using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Contracts.Services.Products
{
    public interface IProductDataAccessService
    {
        Task<ActionResult<Product>> Create(Product product);
        void Update(Product product);
        void Delete(int id);
        Task<IEnumerable<Product>> GetAll();
        Task<ActionResult<IEnumerable<Product>>> GetByCategoryId(int id);
        Product GetOne(int id);
    }
}