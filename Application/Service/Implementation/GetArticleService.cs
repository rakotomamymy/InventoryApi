using Application.Dtos;
using Application.Service.Interface;
using AutoMapper;
using Domains.Repository;
using Domains.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service.Implementation
{
    public class GetArticleService : IGetArticleService
    {
        private readonly IArticleRepository _repo;
        private readonly IMapper _mapper;
        public GetArticleService(IArticleRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
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
