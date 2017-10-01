using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoMapperSample.Domain
{
    public class Catalogue
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
        public int Id { get; set; }
        public List<Book> Books { get; set; }
    }
}
