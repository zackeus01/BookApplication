using System;
using System.Collections.Generic;

namespace FinalProject_BookApplication.Models
{
    public partial class Chapter
    {
        public Chapter()
        {
            Bookmarks = new HashSet<Bookmark>();
        }

        public int ChapterId { get; set; }
        public int? ChapterNumber { get; set; }
        public string? Title { get; set; }
        public int? BookId { get; set; }
        public string? Content { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? Bookmark { get; set; }

        public virtual Book? Book { get; set; }
        public virtual ICollection<Bookmark> Bookmarks { get; set; }
    }
}
