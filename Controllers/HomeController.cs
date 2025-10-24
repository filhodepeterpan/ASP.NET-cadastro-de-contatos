using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using primeira_aplicacao_asp.net_mvc.Models;

namespace primeira_aplicacao_asp.net_mvc.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            HomeModel home = new HomeModel();

            home.Nome = "Douglas";
            home.Email = "douglassoares.cinema@gmail.com";

            return View(home);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
