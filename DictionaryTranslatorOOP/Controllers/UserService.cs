
using DictionaryTranslatorOOP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DictionaryTranslatorOOP.Controllers
{
    public class UserService
    {
        // Создаёт лист
        private static readonly List<User> Users = new List<User>();


        private readonly ILogger<UserService> _logger;

        public UserService(ILogger<UserService> logger)
        {
            _logger = logger;
        }

        public User SignUp(string Username, string Email, string Password, string Role)
        {
            // Коструктурируем юзера
            User user = new User(Random.Shared.Next(1000000, 9999999), Username, Email, Password, Role);

            _logger.LogInformation("Add new User " + user);

            // Добавляет нового юзера в лист 
            Users.Add(user);

            return user;
        }
    }
}