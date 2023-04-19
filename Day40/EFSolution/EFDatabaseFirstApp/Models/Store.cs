using System;
using System.Collections.Generic;

namespace EFDatabaseFirstApp.Models
{
    public partial class Store
    {
        public Store()
        {
            Sales = new HashSet<Sale>();
        }

        public string StorId { get; set; } = null!;
        public string? StorName { get; set; }
        public string? StorAddress { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
