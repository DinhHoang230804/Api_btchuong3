using Btchuong3.Data;
using Btchuong3.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Btchuong3.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly AppDbContext _db;

        public LibraryService(AppDbContext db)
        {
            _db = db;
        }

        // Students Services

        public async Task<List<Author>> GetAuthorsAsync()
        {
            try
            {
                return await _db.authors.ToListAsync();
            }
            catch (Exception ex)
            {
                // Handle exception appropriately
                return null;
            }
        }

        public async Task<Author> GetAuthorAsync(int id)
        {
            try
            {
                return await _db.authors.FindAsync(id);
            }
            catch (Exception ex)
            {
                // Handle exception appropriately
                return null;
            }
        }

        public async Task<Author> AddAuthorAsync(Author author)
        {
            try
            {
                await _db.authors.AddAsync(author);
                await _db.SaveChangesAsync();
                return author;
            }
            catch (Exception ex)
            {
                // Handle exception appropriately
                return null;
            }
        }

        public async Task<Author> UpdateAuthorAsync(Author author)
        {
            try
            {
                _db.Entry(author).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                return author;
            }
            catch (Exception ex)
            {
                // Handle exception appropriately
                return null;
            }
        }

        public async Task<(bool, string)> DeleteAuthorAsync(Author author)
        {
            try
            {
                var Author = await _db.authors.FindAsync(author.Id);
                if (Author == null)
                {
                    return (false, "Student not found.");
                }

                _db.authors.Remove(Author);
                await _db.SaveChangesAsync();
                return (true, "Student deleted successfully.");
            }
            catch (Exception ex)
            {
                // Handle exception appropriately
                return (false, $"An error occurred: {ex.Message}");
            }
        }

        // Courses Services

        public async Task<List<Books>> GetBooksAsync()
        {
            try
            {
                return await _db.books.ToListAsync();
            }
            catch (Exception ex)
            {
                // Handle exception appropriately
                return null;
            }
        }

        public async Task<Books> GetBookAsync(int id)
        {
            try
            {
                return await _db.books.FindAsync(id);
            }
            catch (Exception ex)
            {
                // Handle exception appropriately
                return null;
            }
        }

        public async Task<Books> AddBookAsync(Books book)
        {
            try
            {
                await _db.books.AddAsync(book);
                await _db.SaveChangesAsync();
                return book;
            }
            catch (Exception ex)
            {
                // Handle exception appropriately
                return null;
            }
        }

        public async Task<Books> UpdateBookAsync(Books book)
        {
            try
            {
                _db.Entry(book).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                return book;
            }
            catch (Exception ex)
            {
                // Handle exception appropriately
                return null;
            }
        }

        public async Task<(bool, string)> DeleteBookAsync(Books book)
        {
            try
            {
                var Book = await _db.books.FindAsync(book.BookID);
                if (Book == null)
                {
                    return (false, "Course not found.");
                }

                _db.books.Remove(Book);
                await _db.SaveChangesAsync();
                return (true, "Course deleted successfully.");
            }
            catch (Exception ex)
            {
                // Handle exception appropriately
                return (false, $"An error occurred: {ex.Message}");
            }
        }

        // StudentCourses Services

        public async Task<List<Publishers>> GetPublishersAsync()
        {
            try
            {
                return await _db.publishers.ToListAsync();
            }
            catch (Exception ex)
            {
                // Handle exception appropriately
                return null;
            }
        }

        public async Task<Publishers> GetPublisherAsync(int id)
        {
            try
            {
                return await _db.publishers.FindAsync(id);
            }
            catch (Exception ex)
            {
                // Handle exception appropriately
                return null;
            }
        }

        public async Task<Publishers> AddPublisherAsync(Publishers publishers)
        {
            try
            {
                await _db.publishers.AddAsync(publishers);
                await _db.SaveChangesAsync();
                return publishers;
            }
            catch (Exception ex)
            {
                // Handle exception appropriately
                return null;
            }
        }

        public async Task<Publishers> UpdatePublisherAsync(Publishers publishers)
        {
            try
            {
                _db.Entry(publishers).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                return publishers;
            }
            catch (Exception ex)
            {
                // Handle exception appropriately
                return null;
            }
        }

        public async Task<(bool, string)> DeletePublisherAsync(Publishers publishers)
        {
            try
            {
                var publishers1 = await _db.publishers.FindAsync(publishers.ID);
                if (publishers1 == null)
                {
                    return (false, "Course not found.");
                }

                _db.publishers.Remove(publishers1);
                await _db.SaveChangesAsync();
                return (true, "Course deleted successfully.");
            }
            catch (Exception ex)
            {
                // Handle exception appropriately
                return (false, $"An error occurred: {ex.Message}");
            }
        }
    }
}
