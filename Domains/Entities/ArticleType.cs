using System.Collections.ObjectModel;

namespace Domains.Entities
{
    public class ArticleType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Collection<Article> Articles { get; set; }
    }
}
