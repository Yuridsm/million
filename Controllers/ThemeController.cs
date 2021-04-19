using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Context;
using TodoApi.Models;

namespace TodoApi.Controllers 
{
    [ApiController]
    [Route("v1/[controller]")]
    public class ThemeController : ControllerBase
    {
        public readonly DbContextApplication _context;
        public ThemeController([FromServices] DbContextApplication context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Theme>>> GetAll()
        {
            var res = await _context.Themes.ToListAsync();
            return res;
        }

        [HttpPost]
        [Route("")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Theme>> Create([FromBody] Theme theme)
        {
            var obj = await _context.Themes
            .Where(b => b.Id == theme.Id)
            .FirstOrDefaultAsync();

            if(obj != null)
                return BadRequest();
            
            if(ModelState.IsValid)
            {
                var themee = await _context.Themes.AddAsync(theme);
                await _context.SaveChangesAsync();
            }

            return CreatedAtAction(nameof(Create), new { id = theme.Id }, theme);
        }
    }
}
