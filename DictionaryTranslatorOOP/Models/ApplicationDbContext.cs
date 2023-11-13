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

        public DbSet<User> Users { get; set; }
    }
}
