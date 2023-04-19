using System;
using System.Collections.Generic;

namespace EFDatabaseFirstApp.Models
{
    public partial class Titleauthor
    {
        public string AuId { get; set; } = null!;
        public string TitleId { get; set; } = null!;
        public byte? AuOrd { get; set; }
        public int? Royaltyper { get; set; }

        public virtual Author Au { get; set; } = null!;
        public virtual Title Title { get; set; } = null!;
    }
}
