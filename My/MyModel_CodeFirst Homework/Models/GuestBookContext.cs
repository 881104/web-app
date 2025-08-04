using Microsoft.EntityFrameworkCore;

namespace MyModel_CodeFirst_Homework.Models
{
    public class GuestBookContext:DbContext
    {public GuestBookContext(DbContextOptions<GuestBookContext> options)
        : base(options)
        {
        }
        
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<ReBook> ReBook { get; set; } 

    }
}
