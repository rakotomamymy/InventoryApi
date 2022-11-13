using Api.Mapper;
using Api.ViewModels.Request;
using Application.Service;
using Application.Service.Interface;
using AutoMapper;
using InventoryApi.ViewModels;
using InventoryApi.ViewModels.Result;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryApi.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class ArticleController: ControllerBase
    {
        private readonly IGetArticleService _getSvc;
        private readonly IUpdateArticleService _updateSvc;
        private readonly IDeleteArticleService _deleteSvc;

        public ArticleController(IGetArticleService getSvc, IUpdateArticleService updateSvc, IDeleteArticleService deleteSvc)
        {
            _getSvc = getSvc;
            _updateSvc = updateSvc;
            _deleteSvc = deleteSvc;
        }

        [HttpPost("list")]
        public async Task<ActionResult> ListAsync([FromBody] ArticleListRequestVm filter)
        {
            if (!ModelState.IsValid)
            {
                //Log errors
                return BadRequest("Parameters not valid");
            }

            var dto = _getSvc.List(filter.ToDto());
            if (dto != null)
                return Ok(dto.ToVm());

            return Ok(null);
        }



        [HttpGet("get/{id}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            if (id < 0)
            {
                //Log errors
                return BadRequest("Article Id cannot be < 0");
            }
            var dto = _getSvc.Get(id);
            if (dto != null)
                return Ok(dto.ToVm());

            return Ok(null);
        }

        [HttpPost("edit")]
        public async Task<ActionResult> EditAsync([FromBody] ArticleEditRequestVm article)
        {
            if (!ModelState.IsValid)
            {
                //Log errors
                return BadRequest(false);
            }

            return Ok(_updateSvc.Edit(article.ToDto()));
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            if (id < 0)
            {
                //Log errors
                return BadRequest("Article Id cannot be < 0");
            }

            return Ok(_deleteSvc.Delete(id));
        }
    }
}
