using DictionaryTranslatorOOP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;


namespace DictionaryTranslatorOOP
{
    public class Admin : User
    {
        private List<MyDictionary> Dictionaries { get; set; }

        // Додайте інші властивості користувача, які вам потрібні

        // Contructor 
        public Admin(int userId, string name, string surname, string email, string role)
        : base(userId, name, surname, email, role)
        {

            Dictionaries = new List<MyDictionary>();
        }
        public void addDictionary(MyDictionary dictionary)
        {
            Dictionaries.Add(dictionary);
           
        }

        public void removeDictionary(MyDictionary dictionary)
        {
            Dictionaries.Remove(dictionary);
        }
    }


}