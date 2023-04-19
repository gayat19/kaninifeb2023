using System;
using System.Collections.Generic;

namespace EFDatabaseFirstApp.Models
{
    public partial class Roysched
    {
        public string TitleId { get; set; } = null!;
        public int? Lorange { get; set; }
        public int? Hirange { get; set; }
        public int? Royalty { get; set; }

        public virtual Title Title { get; set; } = null!;
    }
}
