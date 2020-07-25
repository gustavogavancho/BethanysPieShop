using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class Contact : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}