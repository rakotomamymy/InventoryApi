using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos
{
    public class ArticlesFilterDto
    {
        public ArticleFilterDto Filter { get; set; }

        public int Page { get; set; }

        public int PageSize { get; set; }
    }
}
