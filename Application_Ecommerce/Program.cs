using Application_Ecommerce.App.Cart.Mapping;
using Application_Ecommerce.App.Categories.Interfaces;
using Application_Ecommerce.App.Categories.Mapping;
using Application_Ecommerce.App.Categories.Services;
using Application_Ecommerce.App.Extension;
using Application_Ecommerce.Core.Entities.Identity;
using Application_Ecommerce.Core.Interfaces;
using Application_Ecommerce.Core.Interfaces.Repositories;
using Application_Ecommerce.Infrastructure.Persistence;
using Application_Ecommerce.Infrastructure.Persistence.Repository;
using Application_Ecommerce.Mapping.Auth;
using Application_Ecommerce.Mapping.Category;
using Application_Ecommerce.Mapping.Home;
using Application_Ecommerce.Mapping.Product;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

// Add services to the container.
builder.Services.AddRazorPages();

//Dependancy Injection 


builder.Services.AddApplicationRegistration();
builder.Services.AddScoped<IFileHelper, FileHelper>();


builder.Services.AddAutoMapper(typeof(CategoryMappingProfile));
builder.Services.AddAutoMapper(typeof(AuthMappingProfile));
builder.Services.AddAutoMapper(typeof(ProductMappingProfile));
builder.Services.AddAutoMapper(typeof(CouponMappingProfile));
builder.Services.AddAutoMapper(typeof(CartMappingProfile));
builder.Services.AddAutoMapper(typeof(HomeMappingProfile));

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
/// <summary>
/// Point d'entrée de l'application ASP.NET Core (top-level statements).
/// </summary>
/// <remarks>
/// Points pédagogiques :
/// - Depuis .NET 6, le template MVC utilise des top-level statements : le code de démarrage n'est plus dans une méthode Main explicite.
/// - Ce fichier configure le conteneur d'injection de dépendances (services), puis le pipeline HTTP (middlewares) et le routage MVC.
/// - La classe partielle permet d'attacher une documentation XML (et peut servir à certains scénarios de tests), sans modifier le comportement runtime.
/// </remarks>
public partial class Program { }