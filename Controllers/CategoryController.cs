using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TodoApi.Models;
using System.Collections.Generic;
using TodoApi.Contracts.Services.Categories;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryDataAccessService _context;
        public CategoryController(ICategoryDataAccessService context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<Category>>> Get()
        {
            var result = await _context.GetAll();
            if(result != null)
                return Ok(result);
            
            return BadRequest("No result was found");
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Category>> Create([FromBody] Category category)
        {
            if(ModelState.IsValid)
            {
                var result = await _context.Create(category);
                return Created("Create", result);
            }

            return BadRequest();
        }
    }
}
