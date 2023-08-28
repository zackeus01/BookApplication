using System;
using System.Collections.Generic;

namespace FinalProject_BookApplication.Models
{
    public partial class Favorite
    {
        public int FavId { get; set; }
        public int? UserId { get; set; }
        public int? BookId { get; set; }

        public virtual Book? Book { get; set; }
        public virtual User? User { get; set; }
    }
}
