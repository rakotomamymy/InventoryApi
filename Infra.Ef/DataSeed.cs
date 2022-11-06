using Domains.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Ef
{
    public static class DataSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().HasData(
                new Article { Id = 38, Ref = "0001", Name = "apple", Price = 10, Quantity = 6, ArticleTypeId = 1 },
                new Article { Id = 1, Ref = "0002", Name = "apricot", Price = 2, Quantity = 3, ArticleTypeId = 1 },
                new Article { Id = 2, Ref = "0003", Name = "avocado", Price = 7, Quantity = 4, ArticleTypeId = 1 },
                new Article { Id = 3, Ref = "0004", Name = "banana", Price = 15, Quantity = 6, ArticleTypeId = 1 },
                new Article { Id = 4, Ref = "0005", Name = "bell pepper", Price = 6, Quantity = 8, ArticleTypeId = 1 },
                new Article { Id = 5, Ref = "0006", Name = "bilberry", Price = 8, Quantity = 7, ArticleTypeId = 1 },
                new Article { Id = 6, Ref = "0007", Name = "blackberry", Price = 6, Quantity = 9, ArticleTypeId = 1 },
                new Article { Id = 7, Ref = "0008", Name = "blackcurrant", Price = 7, Quantity = 4, ArticleTypeId = 1 },
                new Article { Id = 8, Ref = "0009", Name = "blueberry", Price = 10, Quantity = 6, ArticleTypeId = 1 },
                new Article { Id = 9, Ref = "00010", Name = "boysenberry", Price = 12, Quantity = 7, ArticleTypeId = 1 },
                new Article { Id = 10, Ref = "00011", Name = "breadfruit", Price = 13, Quantity = 1, ArticleTypeId = 1 },
                new Article { Id = 11, Ref = "00012", Name = "cantaloupe", Price = 19, Quantity = 2, ArticleTypeId = 1 },
                new Article { Id = 12, Ref = "00013", Name = "cherimoya", Price = 15, Quantity = 3, ArticleTypeId = 1 },
                new Article { Id = 13, Ref = "00014", Name = "cherry", Price = 13, Quantity = 4, ArticleTypeId = 1 },
                new Article { Id = 14, Ref = "00015", Name = "clementine", Price = 12, Quantity = 5, ArticleTypeId = 1 },
                new Article { Id = 15, Ref = "00016", Name = "cloudberry", Price = 19, Quantity = 6, ArticleTypeId = 1 },
                new Article { Id = 16, Ref = "00017", Name = "coconut", Price = 14, Quantity = 7, ArticleTypeId = 1 },
                new Article { Id = 17, Ref = "00018", Name = "cranberry", Price = 16, Quantity = 8, ArticleTypeId = 1 },
                new Article { Id = 18, Ref = "00019", Name = "cucumber", Price = 12, Quantity = 9, ArticleTypeId = 1 },

                new Article { Id = 19, Ref = "00020", Name = "Article1", Price = 2, Quantity = 1, ArticleTypeId = 2 },
                new Article { Id = 20, Ref = "00021", Name = "Article2", Price = 3, Quantity = 2, ArticleTypeId = 2 },
                new Article { Id = 21, Ref = "00022", Name = "Article3", Price = 5, Quantity = 3, ArticleTypeId = 2 },
                new Article { Id = 22, Ref = "00023", Name = "Article4", Price = 9, Quantity = 4, ArticleTypeId = 2 },
                new Article { Id = 23, Ref = "00024", Name = "Article5", Price = 7, Quantity = 5, ArticleTypeId = 2 },
                new Article { Id = 24, Ref = "00025", Name = "Article6", Price = 5, Quantity = 6, ArticleTypeId = 2 },
                new Article { Id = 25, Ref = "00026", Name = "Article7", Price = 6, Quantity = 7, ArticleTypeId = 2 },
                new Article { Id = 26, Ref = "00027", Name = "Article8", Price = 1, Quantity = 8, ArticleTypeId = 2 },
                new Article { Id = 27, Ref = "00028", Name = "Article9", Price = 12, Quantity = 9, ArticleTypeId = 2 },
                new Article { Id = 28, Ref = "00029", Name = "Article10", Price = 15, Quantity = 1, ArticleTypeId = 2 },
                new Article { Id = 29, Ref = "00030", Name = "Article11", Price = 15, Quantity = 3, ArticleTypeId = 2 },
                new Article { Id = 30, Ref = "00031", Name = "Article12", Price = 13, Quantity = 9, ArticleTypeId = 2 },
                new Article { Id = 31, Ref = "00032", Name = "Article13", Price = 16, Quantity = 7, ArticleTypeId = 2 },
                new Article { Id = 32, Ref = "00033", Name = "Article14", Price = 19, Quantity = 5, ArticleTypeId = 2 },
                new Article { Id = 33, Ref = "00034", Name = "Article15", Price = 18, Quantity = 2, ArticleTypeId = 2 },
                new Article { Id = 34, Ref = "00035", Name = "Article16", Price = 8, Quantity = 2, ArticleTypeId = 2 },
                new Article { Id = 35, Ref = "00036", Name = "Article17", Price = 7, Quantity = 3, ArticleTypeId = 2 },
                new Article { Id = 36, Ref = "00037", Name = "Article18", Price = 6, Quantity = 8, ArticleTypeId = 2 },
                new Article { Id = 37, Ref = "00038", Name = "Article19", Price = 3, Quantity = 9, ArticleTypeId = 2 }
            );

            modelBuilder.Entity<ArticleType>().HasData(
                new ArticleType { Id = 1, Name = "Alimentaire" },
                new ArticleType { Id = 2, Name = "Non alimentaire" }
            );
        }
    }
}
