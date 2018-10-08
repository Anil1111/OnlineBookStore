using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cover2Cover.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category? Category { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Author Author { get; set; }
        public int? AuthorId { get; set; }
        public List<Customer> PurchasedBy { get; set; }

    }
}