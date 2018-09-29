using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoMapperSample.Dto
{
    class BookCatalogPlain
    {
        #region  Catalog
        public string CatalogName { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
        public int Id { get; set; }
        #endregion Catalog

        #region Book
        public string BookName { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        #endregion Book
    }
}
