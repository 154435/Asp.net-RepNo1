using LMS.web.Models;
using Microsoft.EntityFrameworkCore;
namespace LMS.web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Category> Categories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<LMS.web.Models.Author> Author { get; set; }

        public DbSet<Author> Authors { get; set; }
        
    }
}
