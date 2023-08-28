using System;
using System.Collections.Generic;

namespace FinalProject_BookApplication.Models
{
    public partial class Bookmark
    {
        public int BmId { get; set; }
        public int? UserId { get; set; }
        public int? ChapterId { get; set; }

        public virtual Chapter? Chapter { get; set; }
        public virtual User? User { get; set; }
    }
}
