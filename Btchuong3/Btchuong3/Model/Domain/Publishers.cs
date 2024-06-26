﻿using System.ComponentModel.DataAnnotations;

namespace Btchuong3.Model.Domain
{
    public class Publishers
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        //Navigation Properties - One publisher has many books
        public List<Books> Books { get; set; }
    }
}
