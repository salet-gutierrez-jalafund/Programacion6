using LibraryApi.api.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
