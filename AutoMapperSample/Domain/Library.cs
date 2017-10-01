using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoMapperSample.Domain
{
    public class Library
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Catalogue> Catalogues { get; set; }
    }
}
