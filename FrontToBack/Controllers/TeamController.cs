using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
