using System;
using System.Collections.Generic;

namespace FinalProject_BookApplication.Models
{
    public partial class Book
    {
        public Book()
        {
            Chapters = new HashSet<Chapter>();
        }

        public int BookId { get; set; }
        public string? Title { get; set; }
        public int? Author { get; set; }
        public string? Description { get; set; }
        public string? Cover { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? AuthorNavigation { get; set; }
        public virtual ICollection<Chapter> Chapters { get; set; }
    }
}
