using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Repository.Models
{
    public class ArticleFilter
    {
        public string Ref { get; set; }
        public string Name { get; set; }
        public float? Price { get; set; }
        public int? Quantity { get; set; }
        public int? ArticleTypeId { get; set; }
    }
}
