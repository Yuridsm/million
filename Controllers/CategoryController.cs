using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TodoApi.Models;
using TodoApi.DataModel;
using TodoApi.Contracts.Repositories;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly DbContextPostgreSQL _context;
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController([FromServices] DbContextPostgreSQL context, [FromServices] ICategoryRepository categoryRepository)
        {
            _context = context;
            _categoryRepository = categoryRepository;
        }

        [HttpPost]
        public async Task Create()
        {
            var category = new Category() { Title = "Teste2"};
            await _categoryRepository.SaveAsync(category);
        }
    }
}
