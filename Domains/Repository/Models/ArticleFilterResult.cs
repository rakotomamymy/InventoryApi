using Domains.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Repository.Models
{
    public class ArticleFilterResult
    {
        public List<Article> Articles { get; set; }
        public int Count { get; set; }
    }
}
