using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Onlineshop.Data;
using Onlineshop.Models;
using Onlineshop.ViewModels;

namespace Onlineshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index()
        {
            var sliders = _context.BannerItems
                .Where(b => b.Position == "Slider")
                .OrderBy(b => b.Priority)
                .ToList();

            var middleLeftBanner = _context.BannerItems
                .Where(b => b.Position == "MiddleLeftBanner")
                .OrderByDescending(b => b.Priority)
                .FirstOrDefault();

            var middleRightBanner = _context.BannerItems
                .Where(b => b.Position == "MiddleRightBanner")
                .OrderByDescending(b => b.Priority)
                .FirstOrDefault();

            var bottomLeftBanner = _context.BannerItems
                .Where(b => b.Position == "BottomLeftBanner")
                .OrderByDescending(b => b.Priority)
                .FirstOrDefault();

            var bottomRightBanner = _context.BannerItems
                .Where(b => b.Position == "BottomRightBanner")
                .OrderByDescending(b => b.Priority)
                .FirstOrDefault();

            var viewModel = new HomePageBannersViewModel
            {
                Sliders = sliders,
                MiddleLeftBanner = middleLeftBanner,
                MiddleRightBanner = middleRightBanner,
                BottomLeftBanner = bottomLeftBanner,
                BottomRightBanner = bottomRightBanner
            };

            return View(viewModel);
        }














        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
