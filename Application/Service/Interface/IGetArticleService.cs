using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service.Interface
{
    public interface IGetArticleService
    {
        ArticleFilterResultDto List(ArticlesFilterDto filter);
        ArticleDto Get(int id);
    }
}
