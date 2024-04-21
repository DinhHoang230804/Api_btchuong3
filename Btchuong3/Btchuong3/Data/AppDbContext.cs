using Btchuong3.Model;
using Microsoft.EntityFrameworkCore;

namespace Btchuong3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Books> books { get; set; }
        public DbSet<Author> authors { get; set; }
        public DbSet<Book_Author> book_Authors { get; set; }
        public DbSet<Publishers> publishers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book_Author>()
                .HasKey(bc => new { bc.BookID, bc.AuthorID });

            modelBuilder.Entity<Book_Author>()
                .HasOne(bc => bc.Books)
                .WithMany(b => b.Book_Authors)
                .HasForeignKey(bc => bc.BookID);

            modelBuilder.Entity<Book_Author>()
                .HasOne(bc => bc.Author)
                .WithMany(a => a.Book_Authors)
                .HasForeignKey(bc => bc.AuthorID);
        }
    }
}
