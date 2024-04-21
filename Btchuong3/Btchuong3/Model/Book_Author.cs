namespace Btchuong3.Model
{
    public class Book_Author
    {
        public int Id { get; set; }
        public int? BookID { get; set; }
        public int? AuthorID { get; set; }
        public Books? Books { get; set; }

        public Author? Author { get; set; }
    }
}
