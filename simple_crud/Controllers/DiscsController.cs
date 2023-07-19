using Microsoft.AspNetCore.Mvc;

namespace simple_crud.Controllers
{
    [ApiController]
    public class DiscsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
