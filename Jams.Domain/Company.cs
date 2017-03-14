using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jams.Domain
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Reference { get; set; }
        public string Website { get; set; }
    }
}
