using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service.Interface
{
    public interface IUpdateArticleService
    {
        bool Add(ArticleDto article);
        bool Edit(ArticleDto article);
    }
}
