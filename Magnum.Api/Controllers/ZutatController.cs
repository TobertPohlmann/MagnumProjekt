using Magnum.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Magnum.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZutatController : Controller
    {
        private readonly IZutatenRepository _zutatenRepository;

        public ZutatController(IZutatenRepository zutatenRepository)
        {
            _zutatenRepository = zutatenRepository;
        }

        // GET: api/<controller>
        [HttpGet]
        public IActionResult GetZutaten()
        {        
            return Ok(_zutatenRepository.GetAllZutatenFürNutzer(Guid.Empty));
        }
    }
}
