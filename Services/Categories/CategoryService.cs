using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.DataModel;
using TodoApi.Contracts.Services.Categories;
using TodoApi.Models;

namespace TodoApi.Services.Categories
{
    public class CategoryService : ICategoryDataAccessService
    {
        private readonly DbContextInMemory _context;

        public CategoryService(DbContextInMemory context)
        {
            _context = context;
        }
        
        public async Task<ActionResult<Category>> Create(Category category)
        {
            try 
            {
                _context.Categories.Add(category);
                await _context.SaveChangesAsync();
                return category;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return null;
        }

        public async void Delete(int id)
        {
            var product = _context.Categories.FirstOrDefault(t => t.Identifier == id);
            _context.Categories.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<ActionResult<IEnumerable<Category>>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }

        public Category GetOne(int id)
        {
            return _context.Categories.FirstOrDefault(t => t.Identifier == id);
        }

        public async void Update(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }
    }
}