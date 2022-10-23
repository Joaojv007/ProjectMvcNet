using Microsoft.AspNetCore.Mvc;

namespace ProjectMvcNet.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
