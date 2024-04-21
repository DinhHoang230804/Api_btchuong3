﻿using System.ComponentModel.DataAnnotations;

namespace Btchuong3.Model
{
    public class Books
    {
        [Key]
        public int BookID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool? IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public int? Genre { get; set; }
        public string? CoverUrl { get; set; }
        public DateTime? DateAdded { get; set; }
        public int PublisherID { get; set; } // Khóa ngoại
        public Publishers? Publishers { get; set; }
        public List<Book_Author>? Book_Authors { get; set; }
    }
}
