using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApi.ViewModels
{
    public class ArticleRequestVm
    {
        public string Ref { get; set; }
        public string Name { get; set; }
        public float? Price { get; set; }
        public int? Quantity { get; set; }
        public int? ArticleTypeId { get; set; }
    }
}
