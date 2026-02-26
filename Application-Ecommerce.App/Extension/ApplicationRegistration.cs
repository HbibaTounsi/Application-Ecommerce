using Application_Ecommerce.App.Athentication.Interfaces;
using Application_Ecommerce.App.Cart.Interfaces;
using Application_Ecommerce.App.Cart.Mapping;
using Application_Ecommerce.App.Cart.Services;
using Application_Ecommerce.App.Categories.Interfaces;
using Application_Ecommerce.App.Categories.Mapping;
using Application_Ecommerce.App.Categories.Services;
using Application_Ecommerce.App.Coupons.Interfaces;
using Application_Ecommerce.App.Coupons.Mapping;
using Application_Ecommerce.App.Coupons.Services;
using Application_Ecommerce.App.Orders.Interfaces;
using Application_Ecommerce.App.Orders.Mapping;
using Application_Ecommerce.App.Orders.Services;
using Application_Ecommerce.App.Products.Interfaces;
using Application_Ecommerce.App.Products.Mapping;
using Application_Ecommerce.App.Products.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ecommerce.App.Extension
{
    public static class ApplicationRegistration
    {
        public static IServiceCollection AddApplicationRegistration(this IServiceCollection services)
        {
            //registration services
            services.AddScoped<ICategoryService, CategoryServices>();
            services.AddScoped<IAuthService, IAuthService>();
            services.AddScoped<IProductServices, ProductServices>();
            services.AddScoped<ICouponService, CouponServices>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<IOrderServices, OrderServices>();


            //Register AutoMapper Profiles
            services.AddAutoMapper(typeof(CategoryProfile));
            services.AddAutoMapper(typeof(ProductProfile));
            services.AddAutoMapper(typeof(CouponProfile));
            services.AddAutoMapper(typeof(CartMappingProfile));
            services.AddAutoMapper(typeof(OrderMappingProfile));

            return services;
        

        }
    }
}
