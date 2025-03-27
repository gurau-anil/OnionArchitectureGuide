using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureGuide.Domain.Contracts;
using OnionArchitectureGuide.Domain.Entities;
using OnionArchitectureGuide.Persistence.Data;
using OnionArchitectureGuide.Persistence.Repositories;

namespace OnionArchitectureGuide.Persistence
{
    public static class InfrastructureServiceExtensions
    {
        public static void AddInfrastructureServices(this IServiceCollection services, string connectionString)
        {
            //Registering Application DbContext and Seeding Values
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
                options.UseSeeding((context, _) =>
                {
                    var book = context.Set<Book>().FirstOrDefault();
                    if (book == null)
                    {
                        context.Set<Book>().AddRange(BookSeeds());
                        context.SaveChanges();
                    }
                })
                .UseAsyncSeeding(async (context, _, cancellationToken) =>
                    {
                        var book = context.Set<Book>().FirstOrDefaultAsync();
                        if (book == null)
                        {
                            context.Set<Book>().AddRange(BookSeeds());
                            await context.SaveChangesAsync();
                        }
                    });

            });
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
        }
        private static List<Book> BookSeeds()
        {
            return new List<Book> { 
                new Book { Title = "Book 1", Author= new Author(){ Name ="XXX"} }, 
                new Book { Title = "Book 2", Author= new Author(){ Name ="YYY"} }
                };
        }
    }
}
