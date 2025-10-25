using Microsoft.AspNetCore.Mvc;

namespace CadastroDeContatos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
