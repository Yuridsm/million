using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Contracts.Services.Categories
{
    public interface ICategoryDataAccessService
    {
        Task<ActionResult<Category>> Create(Category category);
        void Update(Category category);
        void Delete(int id);
        Task<ActionResult<IEnumerable<Category>>> GetAll();
        Category GetOne(int id);
    }
}