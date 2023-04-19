using System;
using System.Collections.Generic;

namespace EFDatabaseFirstApp.Models
{
    public partial class Sale
    {
        public string StorId { get; set; } = null!;
        public string OrdNum { get; set; } = null!;
        public DateTime OrdDate { get; set; }
        public short Qty { get; set; }
        public string Payterms { get; set; } = null!;
        public string TitleId { get; set; } = null!;

        public virtual Store Stor { get; set; } = null!;
        public virtual Title Title { get; set; } = null!;
    }
}
