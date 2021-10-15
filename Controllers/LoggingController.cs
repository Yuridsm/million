using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Contracts.Repositories;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class LoggingController : ControllerBase
    {
        private readonly ILoggingRepository _loggingRepository;
        public LoggingController([FromServices] ILoggingRepository loggingRepository)
        {
            _loggingRepository = loggingRepository;
        }

        [HttpPost]
        public async Task Insert()
        {
            var logging = new Logging { Identifier = 1, Title = "Logging 01", Description = "..." };
            await _loggingRepository.SaveAsync(logging);
        }
    }
}
