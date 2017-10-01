using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoMapperSample.Dto
{
    public class LibraryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<CatalogueDto> Catalogues { get; set; }
    }
}
