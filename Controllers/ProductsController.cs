using Microsoft.AspNetCore.Mvc;
using WebBanHang.Repository;

namespace WebBanHang.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DataContext _dataContext;
        public ProductsController(DataContext context)
        {
            _dataContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Detail(int Id )
        {
            if(Id ==null) 
            return RedirectToAction("Index");

            var productById = _dataContext.Products.Where(p =>  p.Id == Id).FirstOrDefault();
            return View(productById);
        }
    }
}
