using Microsoft.AspNetCore.Mvc;

namespace DictionaryTranslatorOOP.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult testMethod()
        {
            var controller = new UserController(UserService , "123");
            var result = controller.SignUp() as ViewResult;
        
        }
    }
}
