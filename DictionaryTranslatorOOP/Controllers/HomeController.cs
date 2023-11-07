using Microsoft.AspNetCore.Mvc;

namespace DictionaryTranslatorOOP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
