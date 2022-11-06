using Application.Dtos;
using AutoMapper;
using Domains.Entities;
using Domains.Repository;
using Domains.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _repo;
        private readonly IMapper _mapper;

        public ArticleService(IArticleRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public bool Add(ArticleDto article)
        {
            if (article == null)
            {
                //Log error
                return false;
            }
            return _repo.Add(_mapper.Map<Article>(article));            
        }

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }

        public bool Edit(ArticleDto article)
        {
            if (article == null)
            {
                //Log error
                return false;
            }
            if (article.Id == 0)
                return _repo.Add(_mapper.Map<Article>(article));
            else
                return _repo.Edit(_mapper.Map<Article>(article));
        }

        public ArticleDto Get(int id)
        {
            var article = _repo.Get(id);
            if (article == null)
            {
                //Log error
                return null;
            }
            return _mapper.Map<ArticleDto>(article);
        }

        public ArticleFilterResultDto List(ArticlesFilterDto filter)
        {
            var articles = _repo.List(_mapper.Map<ArticlesFilter>(filter));
            if (articles == null)
            {
                //Log error
                return new ArticleFilterResultDto() { Count = 0, Articles = new List<ArticleDto>() };
            }
            return _mapper.Map<ArticleFilterResultDto>(articles);
        }
    }
}
