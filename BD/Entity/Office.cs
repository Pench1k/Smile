using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Entity
{
    public class Office
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Number { get; set; }
        public int? Floor { get; set; }
    }
}
