using Microsoft.AspNetCore.Mvc;
using MVC_Website.Models;
using System.Diagnostics;

namespace MVC_Website.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
           
            HomeModel home = new HomeModel();

            

            home.Nome = "Gustavo de Alencar";
            home.Email = "gustavo.barros3@outlook.com";

            return View(home);
        }

        public IActionResult Privacy()
             
        {
            PrivacyModel privacy = new PrivacyModel();

            privacy.Phone = "0800-768-942";
            privacy.EmailSupport = "support@aspnet.com";
            return View(privacy);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}