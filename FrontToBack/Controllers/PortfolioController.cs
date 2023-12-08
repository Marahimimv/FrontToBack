using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
