using OnionArchitectureGuide.Domain.Entities;

namespace OnionArchitectureGuide.Domain.Contracts
{
    public interface IAuthorRepository
    {
        Task<Author> GetAllAsync();
    }
}
