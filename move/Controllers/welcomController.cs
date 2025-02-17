using Microsoft.AspNetCore.Mvc;

namespace move.Controllers
{
    public class welcomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
