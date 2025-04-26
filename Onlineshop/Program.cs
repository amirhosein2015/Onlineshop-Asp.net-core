using Microsoft.EntityFrameworkCore;
using Onlineshop.Data;

var builder = WebApplication.CreateBuilder(args);


//برای روش دیتابیس فرست
builder.Services.AddDbContext<OnlineShopContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("OnlineShop")));

//برای روش کد فرست
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppDb")));





// Add services to the container.
builder.Services.AddControllersWithViews();









var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// مسیر Area مدیریت
app.MapControllerRoute(
    name: "admin",
    pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}",
    defaults: new { area = "Admin" });



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");







app.Run();
