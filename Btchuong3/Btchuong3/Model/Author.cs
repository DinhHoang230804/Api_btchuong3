using System.ComponentModel.DataAnnotations;
namespace Btchuong3.Model
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string? FullName { get; set; }

        public List<Book_Author>? Book_Authors { get; set; }
        public List<Books>? Books { get; set; }
    }
}
