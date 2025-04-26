using Microsoft.EntityFrameworkCore;
using Onlineshop.Models;

namespace Onlineshop.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<BannerItem> BannerItems { get; set; }

        // اگر در آینده مدل‌های بیشتری اضافه کنی، اینجا اون‌ها رو هم اضافه می‌کنی
    }
}
