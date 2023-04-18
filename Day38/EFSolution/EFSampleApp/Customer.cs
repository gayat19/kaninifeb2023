using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSampleApp
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  int Age { get; set; }
        public string Phone { get; set; }
        public override string ToString()
        {
            return Id+" "+Name+" "+Age+" "+Phone;
        }
    }
}
