using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebServiceMVC.Data;
using WebServiceMVC.Models.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WebServiceMVCContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("WebServiceMVCContext") ?? throw new InvalidOperationException("Connection string 'WebServiceMVCContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<SellerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();