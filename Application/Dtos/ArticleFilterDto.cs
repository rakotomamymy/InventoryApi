using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos
{
    public class ArticleFilterDto
    {
        public string Ref { get; set; }
        public string Name { get; set; }
        public float? Price { get; set; }
        public int? Quantity { get; set; }
        public int? ArticleTypeId { get; set; }
    }
}
