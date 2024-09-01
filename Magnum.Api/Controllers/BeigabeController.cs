using Magnum.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Magnum.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeigabeController : Controller
    {
        private readonly IBeigabeRepository _beigabenRepository;

        public BeigabeController(IBeigabeRepository beigabenRepository)
        {
            _beigabenRepository = beigabenRepository;
        }

        // GET: api/<controller>
        [HttpGet]
        public IActionResult GetBeigaben()
        {        
            return Ok(_beigabenRepository.GetBeigabeDataFürNutzer(Guid.Empty));
        }
    }
}
