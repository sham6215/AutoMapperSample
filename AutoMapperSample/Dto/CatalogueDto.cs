using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoMapperSample.Dto
{
    public class CatalogueDto
    {
        public string CatalogueDto_Name { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
        public int Id { get; set; }
        public List<BookDto> Books { get; set; }
    }
}
