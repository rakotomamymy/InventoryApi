using Application.Service.Interface;
using AutoMapper;
using Domains.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service.Implementation
{
    public class DeleteArticleService : IDeleteArticleService
    {
        private readonly IArticleRepository _repo;
        private readonly IMapper _mapper;

        public DeleteArticleService(IArticleRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }
    }
}
