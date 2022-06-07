using CleanArchitecture.Domain.Interfaces.Repositories;
using CleanArchitecture.Infrastructure.Persistence.Repositories;
using CleanArchitecture.Application.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using static System.Reflection.Assembly;

namespace CleanArchitecture.WebApi.Extensions
{
    internal static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookRepository, BookRepository>();

            return services;
        }

        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            GetExecutingAssembly().GetTypes().
            Where(item => item.GetInterfaces().
            Where(i => i.IsGenericType).Any(i => i.GetGenericTypeDefinition() == typeof(IUseCaseCommand<>)) && !item.IsAbstract && !item.IsInterface).
            ToList().
            ForEach(assignedTypes =>
            {
                var serviceType = assignedTypes.GetInterfaces().
                                                First(i => i.GetGenericTypeDefinition() == typeof(IUseCaseCommand<>));
            });

            return services;
        }
    }
}
