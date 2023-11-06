using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DictionaryTranslatorOOP.Controllers
{
    // UserController ����������� �� �ontroller
    public class UserController : Controller
    {
        private readonly UserService _userService;
        private readonly ILogger<UserController> _logger;

        public UserController(UserService userService, ILogger<UserController> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult SignUp(string username, string email, string password)
        {
            // ���� ����� ��������� ���
            User user = _userService.SignUp(username, email, password);

            // ��������� ������� ��� ���������������, ���������, �� ������� ������ ���������
            return View("RegistrationSuccess", user);
        }

        [HttpGet(Name = "RegistrationSuccess")]
        public IActionResult RegistrationSuccess()
        {
            return View();
        }
    }
}

