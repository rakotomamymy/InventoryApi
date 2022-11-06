using InventoryApi.ViewModels.Result;
using System.Collections.Generic;

namespace InventoryApi.ViewModels
{
    public class ArticleListResultVm
    {
        public List<ArticleResultVm> Items { get; set; }
        public int Count { get; set; }
    }
}
