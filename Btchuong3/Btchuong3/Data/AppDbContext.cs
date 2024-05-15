using Btchuong3.Model;
using Btchuong3.Model.Domain;
using Btchuong3.Model.DTO;
using Btchuong3.Repositories;
using Microsoft.EntityFrameworkCore;
using Btchuong3.Data;

namespace Btchuong3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Books> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publishers> Publishers { get; set; }
        public DbSet<Model.Domain.Book_Author> BookAuthor { get; set; }
        public DbSet<Image> Images { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Model.Domain.Book_Author>().HasKey(h => new { h.Id, h.AuthorId });

            builder.Entity<Model.Domain.Book_Author>().HasOne(h => h.Book).WithMany(h => h.Book_Authors).HasForeignKey(h => h.Id);

            builder.Entity<Model.Domain.Book_Author>().HasOne(h => h.Author).WithMany(h => h.Book_Authors).HasForeignKey(h => h.AuthorId);

            new DbInitializer(builder).Seed();
        }
    }
}
