using Microsoft.EntityFrameworkCore;
using OnionArchitectureGuide.Domain.Contracts;
using OnionArchitectureGuide.Domain.Entities;
using OnionArchitectureGuide.Persistence.Data;

namespace OnionArchitectureGuide.Persistence.Repositories
{
    internal class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationDbContext _context;

        public AuthorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Author>> GetAllAsync()
        {
            return await _context.Authors.ToListAsync();
        }
    }
}
