using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Onlineshop.Data;

namespace Onlineshop.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly OnlineShopContext _context;


        public HomeController(OnlineShopContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Menus.ToListAsync());
        }
    }
}
