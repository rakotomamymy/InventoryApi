using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos
{
    public class ArticleFilterResultDto
    {
        public List<ArticleDto> Articles { get; set; }
        public int Count { get; set; }
    }
}
