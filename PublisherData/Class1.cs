
using Microsoft.EntityFrameworkCore;
using PublisherDomail;

namespace PublishData1
{
    public class pubContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                    "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PublishData1");
        }

    }
}
