using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using move.data;
using move.Models;

namespace move.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDBcontext _context = new ApplicationDBcontext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var mooove = _context.Moooves.ToList();
            return View(mooove);
        }

        public IActionResult Details(int id)
        {
                var mooove = _context.Moooves.Find(id);
            // var mooove = _context.Moooves.Where(e=>e.Id == 1) .FirstOrDefault();
            if (mooove != null)
            {
                return View(mooove);
            }
                return Redirect("Notfoundpage");
        }
       public IActionResult Notfoundpage()
       {

        return View();
       }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()

            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }
