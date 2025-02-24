using Microsoft.AspNetCore.Mvc;

namespace EstoqueWeb2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
