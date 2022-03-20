using Microsoft.AspNetCore.Mvc;

namespace FirstWeb.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}