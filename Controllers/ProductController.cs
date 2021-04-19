using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Contracts.Services.Products;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class ProductController: ControllerBase
    {
        private readonly IProductDataAccessService _data;
        public ProductController([FromServices] IProductDataAccessService data)
        {
            _data = data;
        }

        [HttpGet]
        [Route("{id:int}")]
        public Product Get([FromQuery] int id)
        {
            return _data.GetOne(id);
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Product>> Create([FromBody] Product product)
        {
            if(ModelState.IsValid)
            {
                var result = await _data.Create(product);
                return Created("Create", result);
            }

            return BadRequest();
        }

        [HttpGet]
        [Route("category/{id:int}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetById([FromQuery] int id)
        {
            var result = await _data.GetByCategoryId(id);
            return Ok(result);
        }
    }
}
