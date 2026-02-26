using Application_Ecommerce.Core.Entities.Identity;
using Application_Ecommerce.Core.Interfaces.Repositories;
using Application_Ecommerce.Core.Interfaces.Repositories.Base;
using Application_Ecommerce.Infrastructure.Persistence;
using Application_Ecommerce.Infrastructure.Persistence.Repositories;
using Application_Ecommerce.Infrastructure.Persistence.Repository;
using Application_Ecommerce.Infrastructure.Persistence.Repository.Base;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Application_Ecommerce.App.Categories.Mapping;
using AutoMapper;
using Application_Ecommerce.Mapping.Category;
using Application_Ecommerce.Mapping.Home;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

// Add services to the container.
builder.Services.AddRazorPages();

//Dependancy Injection 
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IAuthRepository, AuthRepository>();

builder.Services.AddAutoMapper(typeof(CategoryMappingProfile));
builder.Services.AddAutoMapper(typeof(HomeMappingProfile));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
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
