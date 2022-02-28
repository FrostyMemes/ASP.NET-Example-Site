using Microsoft.AspNetCore.Mvc;

namespace FirstWeb.Controllers
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