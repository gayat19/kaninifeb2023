using System;
using System.Collections.Generic;

namespace EFDatabaseFirstApp.Models
{
    public partial class Title
    {
        public Title()
        {
            Sales = new HashSet<Sale>();
            Titleauthors = new HashSet<Titleauthor>();
        }

        public string TitleId { get; set; } = null!;
        public string Title1 { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string? PubId { get; set; }
        public decimal? Price { get; set; }
        public decimal? Advance { get; set; }
        public int? Royalty { get; set; }
        public int? YtdSales { get; set; }
        public string? Notes { get; set; }
        public DateTime Pubdate { get; set; }

        public virtual Publisher? Pub { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<Titleauthor> Titleauthors { get; set; }
    }
}
