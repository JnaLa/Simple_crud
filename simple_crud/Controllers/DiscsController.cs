using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using simple_crud.Data;

namespace simple_crud.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class DiscsController : Controller
    {
        private readonly SimpleCrudDbContext _simpleCrudDbContext;
        public DiscsController(SimpleCrudDbContext simpleCrudDbContext)
        {
            _simpleCrudDbContext = simpleCrudDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDiscs()
        {
            var discs = await _simpleCrudDbContext.Discs.ToListAsync();

            return Ok(discs);
        }
    }
}
