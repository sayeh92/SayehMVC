using Microsoft.AspNetCore.Mvc;

namespace SayehMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
