using Application.Dtos;
using AutoMapper;
using Domains.Entities;
using Domains.Repository.Models;

namespace Application.Mapper
{
    public class ArticleProfile: Profile
    {
        public ArticleProfile()
        {
            CreateMap<Article, ArticleDto>().ReverseMap();
            CreateMap<ArticleType, ArticleTypeDto>().ReverseMap();
            CreateMap<ArticlesFilter, ArticlesFilterDto>().ReverseMap();
            CreateMap<ArticleFilter, ArticleFilterDto>().ReverseMap();
            CreateMap<ArticleFilterResult, ArticleFilterResultDto>().ReverseMap();
        }
    }
}
