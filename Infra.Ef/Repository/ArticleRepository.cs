using Domains.Entities;
using Domains.Repository;
using Domains.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Ef.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly InventoryContext _context;

        public ArticleRepository(InventoryContext context)
        {
            this._context = context;
        }

        public bool Delete(int id)
        {
            try {
                if (id == 0)
                {
                    //Log error
                    return false;
                }

                var foundArticle = this._context.Articles.FirstOrDefault(a => a.Id == id);
                if (foundArticle == null)
                    return true;
                this._context.Articles.Remove(foundArticle);
                this._context.SaveChanges();
                return true;
            } catch(Exception ex)
            {
                //Log errors
                return false;
            }
        }

        public bool Add(Article article)
        {
            try
            {
                if (article == null || article.Id != 0)
                {
                    //Log error
                    return false;
                }

                _context.Add(article);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //Log errors
                return false;
            }
        }

        public bool Edit(Article article)
        {
            try
            {
                if (article == null || article.Id == 0) { 
                    //Log error
                    return false;
                }

                var foundArticle = _context.Articles.FirstOrDefault(a => a.Id == article.Id);
                if (foundArticle == null) {
                    //Log error
                    return false;
                }

                foundArticle.Ref = article.Ref;
                foundArticle.Name = article.Name;
                foundArticle.Price = article.Price;
                foundArticle.Quantity = article.Quantity;
                foundArticle.ArticleTypeId = article.ArticleTypeId;

                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //Log errors
                return false;
            }
        }

        public Article Get(int id)
        {
            try
            {
                if (id == 0)
                {
                    //Log error
                    return null;
                }

                return _context.Articles.Include(a => a.ArticleType).FirstOrDefault(a => a.Id == id);
            } catch(Exception ex)
            {
                //Log error
                return null;
            }
        }

        public ArticleFilterResult List(ArticlesFilter filter)
        {
            try
            {
                var res = new ArticleFilterResult();

                IQueryable<Article> filtered = _context.Articles.Include(a => a.ArticleType);
                if (!string.IsNullOrEmpty(filter.Filter.Ref))
                    filtered = filtered.Where(a => a.Ref.ToLower().Contains(filter.Filter.Ref.ToLower()));
                if (!string.IsNullOrEmpty(filter.Filter.Name))
                    filtered = filtered.Where(a => a.Name.ToLower().Contains(filter.Filter.Name.ToLower()));
                if (filter.Filter.Price != null)
                    filtered = filtered.Where(a => a.Price == filter.Filter.Price);
                if (filter.Filter.Quantity != null)
                    filtered = filtered.Where(a => a.Quantity == filter.Filter.Quantity);
                if (filter.Filter.ArticleTypeId != null)
                    filtered = filtered.Where(a => a.ArticleTypeId == filter.Filter.ArticleTypeId);

                res.Count = filtered.Count();

                filtered = filtered.Skip(filter.PageSize * (filter.Page - 1)).Take(filter.PageSize);

                res.Articles = filtered.ToList();

                return res;
            } catch(Exception ex)
            {
                //Log error
                return new ArticleFilterResult() { Count = 0, Articles = new List<Article>() };
            }
        }
    }
}
