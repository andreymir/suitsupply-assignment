using StringParser.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace StringParser.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntityValidationController : ControllerBase
    {
        private readonly IParseService _parseService;

        public EntityValidationController(IParseService service)
        {
            _parseService = service;
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            var result = _parseService.ConvertFromText(value);
            return Ok(result);
        }
    }
}
