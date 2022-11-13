using Application.Dtos;
using Application.Service.Interface;
using AutoMapper;
using Domains.Entities;
using Domains.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service.Implementation
{
    public class UpdateArticleService : IUpdateArticleService
    {
        private readonly IArticleRepository _repo;
        private readonly IMapper _mapper;

        public UpdateArticleService(IArticleRepository repo, IMapper mapper)
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
    }
}
