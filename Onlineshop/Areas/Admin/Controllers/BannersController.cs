using Microsoft.AspNetCore.Mvc;
using Onlineshop.Models;
using Microsoft.EntityFrameworkCore;
using Onlineshop.Data;


namespace Onlineshop.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class BannerItemController : Controller
    {
        private readonly AppDbContext _context; // ✅ اینجا اصلاح شد
        private readonly IWebHostEnvironment _environment;

        public BannerItemController(AppDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }





        [HttpPost]
        public async Task<IActionResult> Create(BannerItem banner, IFormFile imageFile)
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                var uploadsFolder = Path.Combine(_environment.WebRootPath, "images", "banners");
                Directory.CreateDirectory(uploadsFolder);

                var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }

                banner.ImageName = uniqueFileName;
            }


            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState)
                {
                    Console.WriteLine($"{error.Key}: {string.Join(", ", error.Value.Errors.Select(e => e.ErrorMessage))}");
                }
            }



            if (ModelState.IsValid)
            {
                _context.BannerItems.Add(banner);
                await _context.SaveChangesAsync();
                return RedirectToAction("List");
            }


            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                Console.WriteLine("ModelState Error: " + error.ErrorMessage);
            }


            return View(banner);
        }





        [HttpGet]
        public IActionResult Edit(int id)
        {
            var banner = _context.BannerItems.Find(id);
            if (banner == null)
            {
                return NotFound();
            }

            return View(banner);
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, BannerItem model, IFormFile? imageFile)
        {
            var banner = _context.BannerItems.Find(id);
            if (banner == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                // اطلاعات اصلی را آپدیت کن
                banner.Title = model.Title;
                banner.Link = model.Link;
                banner.Description = model.Description;
                banner.Position = model.Position;
                banner.Priority = model.Priority;

                // اگر عکس جدید آپلود شده باشد
                if (imageFile != null && imageFile.Length > 0)
                {
                    // مسیر پوشه آپلود عکس‌ها
                    var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/banners");

                    // ساخت اسم جدید برای عکس
                    var newFileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                    var newFilePath = Path.Combine(uploadPath, newFileName);

                    // ذخیره فایل جدید
                    using (var stream = new FileStream(newFilePath, FileMode.Create))
                    {
                        imageFile.CopyTo(stream);
                    }

                    // حذف عکس قبلی اگر وجود داشته باشد
                    if (!string.IsNullOrEmpty(banner.ImageName))
                    {
                        var oldFilePath = Path.Combine(uploadPath, banner.ImageName);
                        if (System.IO.File.Exists(oldFilePath))
                        {
                            System.IO.File.Delete(oldFilePath);
                        }
                    }

                    // ثبت اسم عکس جدید در دیتابیس
                    banner.ImageName = newFileName;
                }

                _context.SaveChanges();
                return RedirectToAction("List");
            }

            return View(model);
        }







        [HttpGet]
        public IActionResult Delete(int id)
        {
            var banner = _context.BannerItems.Find(id);
            if (banner == null)
            {
                return NotFound();
            }

            return View(banner);
        }




        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var banner = _context.BannerItems.Find(id);
            if (banner == null)
            {
                return NotFound();
            }

            // حذف فایل عکس از سرور
            if (!string.IsNullOrEmpty(banner.ImageName))
            {
                var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/banners", banner.ImageName);
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }
            }

            // حذف رکورد از دیتابیس
            _context.BannerItems.Remove(banner);
            _context.SaveChanges();

            return RedirectToAction("List");
        }












        public IActionResult List()
        {
            var items = _context.BannerItems.ToList();
            return View(items);
        }
    }




}




