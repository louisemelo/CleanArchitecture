using CleanArchitecture.Application.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using static System.Reflection.Assembly;

[assembly: InternalsVisibleTo("CleanArchitecture.WebApi")]
namespace CleanArchitecture.Application.Configuration
{
    internal static class UseCasesConfiguration
    {
        public static IServiceCollection AddRegisterUseCasesCommands(this IServiceCollection services)
        {
            GetExecutingAssembly().GetTypes().
            Where(item => item.GetInterfaces().
            Where(i => i.IsGenericType).Any(i => i.GetGenericTypeDefinition() == typeof(IUseCaseCommand<>)) && !item.IsAbstract && !item.IsInterface).
            ToList().
            ForEach(assignedTypes =>
            {
                var serviceType = assignedTypes.GetInterfaces().First(i => i.GetGenericTypeDefinition() == typeof(IUseCaseCommand<>));
                services.AddScoped(serviceType, assignedTypes);

            });

            return services;
        }

        public static IServiceCollection AddRegisterUseCasesQueries(this IServiceCollection services)
        {
            GetExecutingAssembly().GetTypes().
            Where(item => item.GetInterfaces().
            Where(i => i.IsGenericType).Any(i => i.GetGenericTypeDefinition() == typeof(IUseCaseQuery<>)) && !item.IsAbstract && !item.IsInterface).
            ToList().
            ForEach(assignedTypes =>
            {
                var serviceType = assignedTypes.GetInterfaces().First(i => i.GetGenericTypeDefinition() == typeof(IUseCaseQuery<>));
                services.AddScoped(serviceType, assignedTypes);

            });

            return services;
        }
    }
}
