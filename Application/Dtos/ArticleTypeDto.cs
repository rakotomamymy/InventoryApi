using Application.Dtos;
using System.Collections.ObjectModel;

namespace Application.Dtos
{
    public class ArticleTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Collection<ArticleDto> Articles { get; set; }
    }
}
