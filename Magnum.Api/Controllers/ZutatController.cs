using Magnum.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Magnum.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZutatController : Controller
    {
        private readonly IZutatRepository _zutatenRepository;

        public ZutatController(IZutatRepository zutatenRepository)
        {
            _zutatenRepository = zutatenRepository;
        }

        // GET: api/<controller>
        [HttpGet]
        public IActionResult GetZutaten()
        {        
            return Ok(_zutatenRepository.GetZutatDataFürNutzer(Guid.Empty));
        }
    }
}
