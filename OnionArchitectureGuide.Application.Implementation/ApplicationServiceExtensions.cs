using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureGuide.Application.Abstraction.Contracts;
using OnionArchitectureGuide.Application.Implementation.Services;
using System.Reflection;

namespace OnionArchitectureGuide.Application.Implementation
{
    public static class ApplicationServiceExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IBookService,BookService>();
            services.AddScoped<IAuthorService,AuthorService>();
        }
    }
}
