using Application_Ecommerce.App.Products.Dtos;
using Application_Ecommerce.Core.Entities.Identity;
using Application_Ecommerce.Models.Home;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace Application_Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }
    }
}
