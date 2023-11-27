using Microsoft.EntityFrameworkCore;
using DictionaryTranslatorOOP.Models;

namespace DictionaryTranslatorOOP.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Dictionary> Dictionary { get; set; }
        public DbSet<Users> Users { get; set; }


        //public DbSet<Response> Response { get; set; }  ----- model response
        //public DbSet<Word> Word { get; set; }   ------ model word
    }
}
