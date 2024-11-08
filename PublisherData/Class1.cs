using Microsoft.EntityFrameworkCore;
using PublisherDomail;

namespace PublishData1
{
    public class PubContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=GABRIEL\\SQLEXPRESS;Initial Catalog=PublishData;Integrated Security=True;TrustServerCertificate=True;"
);
        }
    }
}
