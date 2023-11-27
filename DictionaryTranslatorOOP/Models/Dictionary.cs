using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DictionaryTranslatorOOP.Models
{
    public class Dictionary
    {
        [Key]
        public int DictID { get; set; }

        public string DictLanguage { get; set; }
    }
}
