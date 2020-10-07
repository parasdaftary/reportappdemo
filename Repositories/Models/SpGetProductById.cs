using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class SpGetProductById
    {
        public string ProductKey { get; set; }
        public string EnglishProductName { get; set; }
        public string EnglishDescription { get; set; }
        public string EnglishProductSubcategoryName { get; set; }
    }
}
