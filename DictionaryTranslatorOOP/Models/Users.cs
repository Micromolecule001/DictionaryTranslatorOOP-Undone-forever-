using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DictionaryTranslatorOOP.Models
{
    public class Users
    {
        [Key]
        public static int UserID { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public static string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
