using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBookGallery.Models
{
    public class ComicBookModel
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHTML { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }
    }
}
