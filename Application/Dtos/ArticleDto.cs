namespace Application.Dtos
{
    public class ArticleDto
    {
        public int Id { get; set; }
        public string Ref { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        public int ArticleTypeId { get; set; }
        public ArticleTypeDto ArticleType { get; set; }
    }
}
