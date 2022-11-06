using Domains.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Repository.Models
{
    public class ArticlesFilter
    {
        public ArticleFilter Filter { get; set; }

        public int Page { get; set; }

        public int PageSize { get; set; }
    }
}
