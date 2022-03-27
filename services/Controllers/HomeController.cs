using Microsoft.AspNetCore.Mvc;

namespace services.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}