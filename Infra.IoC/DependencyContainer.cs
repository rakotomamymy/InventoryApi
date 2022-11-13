using Application.Service;
using Application.Service.Implementation;
using Application.Service.Interface;
using Domains.Repository;
using Infra.Ef;
using Infra.Ef.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.IoC
{
    public static class DependencyContainer
    {
        public static void AddDependencies(this IServiceCollection services, string dbConnectionString)
        {
            services.AddDbContext<InventoryContext>(options => options.UseSqlServer(dbConnectionString));

            services.AddScoped<IArticleRepository, ArticleRepository>();

            services.AddScoped<IGetArticleService, GetArticleService>();
            services.AddScoped<IDeleteArticleService, DeleteArticleService>();
            services.AddScoped<IUpdateArticleService, UpdateArticleService>();
        }
    }
}
