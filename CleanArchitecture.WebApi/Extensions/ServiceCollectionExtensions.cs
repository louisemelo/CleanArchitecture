using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Interfaces.Repositories;
using CleanArchitecture.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CleanArchitecture.WebApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookRepository, BookRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services;
        }
    }
}
