using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApi.ViewModels
{
    public class ArticleListRequestVm
    {
        public ArticleRequestVm Filter { get; set; }

        [Range(1, 1000, ErrorMessage = "Number between 1 and 1000")]
        public int Page { get; set; }

        [Range(1, 50, ErrorMessage = "Number between 1 and 50")]
        public int PageSize { get; set; }
    }
}
