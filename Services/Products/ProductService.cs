using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.DataModel;
using TodoApi.Contracts.Services.Products;
using TodoApi.Models;

namespace TodoApi.Services.Products
{
    public class ProductService : IProductDataAccessService
    {
        private readonly DbContextInMemory _context;

        public ProductService(DbContextInMemory context)
        {
            _context = context;
        }
        
        public async Task<ActionResult<Product>> Create(Product product)
        {
            try
            {
                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return product;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return null;
        }

        public async void Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(t => t.Id == id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<ActionResult<IEnumerable<Product>>> GetByCategoryId(int id)
        {
            return await _context.Products
                .Where(t => t.CategoryId == id)
                .ToListAsync<Product>();
        }

        public Product GetOne(int id)
        {
            return _context.Products.FirstOrDefault(t => t.Id == id);
        }

        public async void Update(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}