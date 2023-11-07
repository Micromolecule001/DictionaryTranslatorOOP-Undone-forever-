using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DictionaryTranslatorOOP.Models
{
    public class User
    {
        private int Id { get; set; }
        private string Username { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private string Role { get; set; }
        // Додайте інші властивості користувача, які вам потрібні

        // Contructor 
        public User(int id, string username, string email, string password, string role)
        {
            Id = id;
            Username = username;
            Email = email;
            Password = password;
            Role = role;
        }
    }


}