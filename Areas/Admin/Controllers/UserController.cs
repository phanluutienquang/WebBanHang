using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebBanHang.Repository;

namespace WebBanHang.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        private readonly DataContext _dataContext;
        public UserController(DataContext context)
        {
            _dataContext = context;

        }
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            return View(await _dataContext.Users.OrderByDescending(p => p.Id).ToListAsync());
        }
    }
}
