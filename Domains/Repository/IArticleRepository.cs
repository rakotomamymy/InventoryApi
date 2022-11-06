using Domains.Entities;
using Domains.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Repository
{
    public interface IArticleRepository
    {
        ArticleFilterResult List(ArticlesFilter filter);
        Article Get(int id);
        bool Add(Article article);
        bool Edit(Article article);
        bool Delete(int id);
    }
}
