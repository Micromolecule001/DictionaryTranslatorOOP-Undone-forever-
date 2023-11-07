using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DictionaryTranslatorOOP
{
    public class MyDictionary
    {
        private Dictionary<string, string> _dictionary;
        // Додайте інші властивості користувача, які вам потрібні

        // Contructor 
        public MyDictionary()
        {
               _dictionary = new Dictionary<string, string>();
        }

        public void Add(string key, string value)
        {
            _dictionary.Add(key, value);
        }

        public bool Remove(string key)
        {
            return _dictionary.Remove(key);
        }

        public string GetValue(string key)
        {
            if (_dictionary.TryGetValue(key, out string value)) 
            {
                return value;
            } else
            {
                return null;
            }
        }
    }


}