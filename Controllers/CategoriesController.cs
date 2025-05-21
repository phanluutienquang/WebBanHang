using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebBanHang.Models;
using WebBanHang.Repository;

namespace WebBanHang.Controllers
{
  
    public class CategoriesController : Controller
    {
        private readonly DataContext _dataContext;
        public CategoriesController(DataContext context)
        {
            _dataContext = context;
        }
        public async Task<IActionResult> Index(string Slug = "")
        {
            CategoryModel category = _dataContext.Categories.Where(c =>  c.Slug == Slug).FirstOrDefault();
            if (category == null)
            
                return RedirectToAction("Index");

                var productByCategory = _dataContext.Products.Where(p => p.CategoryId == category.Id);
            
            return View(await productByCategory.OrderByDescending(p => p.Id).ToListAsync());
        }
    }
}
