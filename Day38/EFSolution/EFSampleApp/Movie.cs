using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSampleApp
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float? Rating { get; set; }
        public override string ToString()
        {
            return Id+" "+Name+" "+Rating;
        }
    }
}
