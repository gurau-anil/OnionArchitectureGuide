using OnionArchitectureGuide.Domain.Entities;

namespace OnionArchitectureGuide.Domain.Contracts
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllAsync();
    }
}
