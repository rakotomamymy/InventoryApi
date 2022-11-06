using Api.ViewModels.Request;
using Application.Dtos;
using InventoryApi.ViewModels;
using InventoryApi.ViewModels.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Mapper
{
    public static class ArticleMapping
    {
        public static ArticleFilterDto ToDto(this ArticleRequestVm vm)
        {
            return new ArticleFilterDto
            {
                Ref = vm.Ref,
                Name = vm.Name,
                Price = vm.Price,
                Quantity = vm.Quantity,
                ArticleTypeId = vm.ArticleTypeId
            };
        }
        public static ArticleDto ToDto(this ArticleEditRequestVm vm)
        {
            return new ArticleDto
            {
                Id = vm.Id,
                Ref = vm.Ref,
                Name = vm.Name,
                Price = vm.Price,
                Quantity = vm.Quantity,
                ArticleTypeId = vm.ArticleTypeId
            };
        }
        public static ArticlesFilterDto ToDto(this ArticleListRequestVm vm)
        {
            return new ArticlesFilterDto {
                Page = vm.Page,
                PageSize = vm.PageSize,
                Filter = vm.Filter.ToDto()
            };
        }

        public static ArticleResultVm ToVm(this ArticleDto dto)
        {
            return new ArticleResultVm
            {
                Id = dto.Id,
                Ref = dto.Ref,
                Name = dto.Name,
                Price = dto.Price,
                Quantity = dto.Quantity,
                ArticleTypeId = dto.ArticleTypeId,
                ArticleTypeName = dto.ArticleType.Name
            };
        }
        public static ArticleListResultVm ToVm(this ArticleFilterResultDto dto)
        {
            return new ArticleListResultVm
            {
                Count = dto.Count,
                Items = dto.Articles.Select(a => a.ToVm()).ToList()
            };
        }

    }
}
