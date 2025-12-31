using Microsoft.EntityFrameworkCore;
using UniversityPortal.Data;

var builder = WebApplication.CreateBuilder(args);

// 1. Services
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("UniversityPortal")));

var app = builder.Build(); // Must be after all builder.Services

// 2. Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // UseStaticFiles instead of MapStaticAssets for standard MVC
app.UseRouting();
app.UseAuthorization();

// 3. Routes
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Portal}/{action=Index}/{id?}");

app.Run();