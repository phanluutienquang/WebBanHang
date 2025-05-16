using Microsoft.AspNetCore.Mvc;

namespace WebBanHang.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
