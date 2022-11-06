using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service
{
    public interface IArticleService
    {
        ArticleFilterResultDto List(ArticlesFilterDto filter);
        ArticleDto Get(int id);
        bool Add(ArticleDto article);
        bool Edit(ArticleDto article);
        bool Delete(int id);
    }
}
