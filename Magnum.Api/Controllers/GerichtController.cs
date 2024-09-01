using Magnum.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Magnum.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GerichtController : Controller
    {
        private readonly IGerichtRepository _gerichtRepository;

        public GerichtController(IGerichtRepository gerichtRepository)
        {
            _gerichtRepository = gerichtRepository;
        }

        // GET: api/<controller>
        [HttpGet]
        public IActionResult GetGerichte()
        {        
            return Ok(_gerichtRepository.GetAllGerichteFürNutzer(Guid.Empty));
        }
    }
}
