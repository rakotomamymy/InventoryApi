namespace Domains.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public string Ref { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        public int ArticleTypeId { get; set; }
        public virtual ArticleType ArticleType { get; set; }
    }
}
