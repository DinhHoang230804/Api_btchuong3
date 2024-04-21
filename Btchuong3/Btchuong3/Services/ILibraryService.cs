using Btchuong3.Model;

namespace Btchuong3.Services
{
    public interface ILibraryService
    {
        // Authors
        Task<List<Author>> GetAuthorsAsync();
        Task<Author> GetAuthorAsync(int id);
        Task<Author> AddAuthorAsync(Author author);
        Task<Author> UpdateAuthorAsync(Author author);
        Task<(bool,string)> DeleteAuthorAsync(Author author);

        // Publishers
        Task<List<Publishers>> GetPublishersAsync();
        Task<Publishers> GetPublisherAsync(int id);
        Task<Publishers> AddPublisherAsync(Publishers publisher);
        Task<Publishers> UpdatePublisherAsync(Publishers publisher);
        Task<(bool, string)> DeletePublisherAsync(Publishers publisher);

        // Books
        Task<List<Books>> GetBooksAsync();
        Task<Books> GetBookAsync(int id);
        Task<Books> AddBookAsync(Books book);
        Task<Books> UpdateBookAsync(Books book);
        Task<(bool, string)> DeleteBookAsync(Books book);
    }
}
