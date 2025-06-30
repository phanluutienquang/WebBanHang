using Microsoft.AspNetCore.Mvc;


using Microsoft.AspNetCore.Authorization;
using WebBanHang.Repository;
using Microsoft.EntityFrameworkCore;

namespace WebBanHang.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Role")]
    [Authorize(Roles="Admin")]
    public class RoleController : Controller
    {
        private readonly DataContext _dataContext;

        public RoleController(DataContext context)
        {
            _dataContext = context;

        }

        
        public async Task<IActionResult> Index()
        {
            return View(await _dataContext.Roles.OrderByDescending(p => p.Id).ToListAsync());
        }
    }
}
