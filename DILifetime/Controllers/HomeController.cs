using DILifetime.Services;
using Microsoft.AspNetCore.Mvc;

namespace DILifetime.Controllers
{
    public class HomeController : Controller
    {
        private readonly IScopedGuidService _scoped1;
        private readonly IScopedGuidService scoped2


        public IActionResult Index()
        {
            return View();
        }
    }
}
