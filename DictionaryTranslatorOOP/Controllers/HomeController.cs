using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DictionaryTranslatorOOP.Models;
using Microsoft.EntityFrameworkCore;

namespace DictionaryTranslatorOOP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ExecuteQuery(String QueryOption)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true");

            var db = new ApplicationDbContext(optionsBuilder.Options);
            String SQLQuery;

            switch(QueryOption)
            {
                // Вибір користувачів з емейлом, який починається з 'j':
                case "query1":
                    SQLQuery = ApplicationDbContext.Users.Where(u => u.Email.StartsWith("j"));
            }

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}







//Оновлення стовпця 'DictTest' в таблиці 'Dictionary' для рядка з DictID = 1 на значення 'test' та вибір всіх записів:
var dictionaryEntry = context.Dictionary.FirstOrDefault(d => d.DictID == 1);
if (dictionaryEntry != null)
{
    dictionaryEntry.DictTest = "test";
    context.SaveChanges();
}
var updatedDictionary = context.Dictionary.ToList();




var dictionaryCount = context.Dictionary.Count();