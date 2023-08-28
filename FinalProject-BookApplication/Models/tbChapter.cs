using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_BookApplication.Models
{
    public partial class tbChapter
    {
        public tbChapter(Chapter c)
        {
            chapter = c;
            actEdit = "Edit";
            actRead = "Read";
        }

        public Chapter chapter { get; set; }
        public string actRead { get; set; }
        public string actEdit { get; set; }
    }
}
