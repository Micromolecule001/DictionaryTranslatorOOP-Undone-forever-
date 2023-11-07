using DictionaryTranslatorOOP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using static Google.Apis.Translate.v2.TranslationsResource;

namespace DictionaryTranslatorOOP.Controllers
{
    // UserController наслідується від controller
    public class UserController : Controller
    {
        private readonly TranslateRequest _TranslateRequest;
        private readonly UserService _UserService;
        private readonly ILogger<UserController> _logger;

        public UserController(UserService userService, ILogger<UserController> logger, TranslateRequest TranslateRequest)
        {
            _TranslateRequest = TranslateRequest;
            _UserService = userService;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult SignUp(string username, string email, string password, string role)
        {
            // ���� ����� ��������� ���
            User user = _UserService.SignUp(username, email, password, role);

            // ��������� ������� ��� ���������������, ���������, �� ������� ������ ���������
            return View("RegistrationSuccess", user);
        }

        [HttpPost]
        public IActionResult Translate(TranslateRequest request)
        {
            string translatedText = _TranslateRequest.TranslateText(request.Text, "en"); // Припустимо, що ми перекладаємо на англійську

            return Json(translatedText);
        }
    }
}

