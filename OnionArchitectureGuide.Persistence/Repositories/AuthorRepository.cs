using OnionArchitectureGuide.Domain.Contracts;
using OnionArchitectureGuide.Domain.Entities;

namespace OnionArchitectureGuide.Persistence.Repositories
{
    internal class AuthorRepository : IAuthorRepository
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorRepository(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        public async Task<IEnumerable<Author>> GetAllAsync()
        {
            return await _authorRepository.GetAllAsync();
        }
    }
}
