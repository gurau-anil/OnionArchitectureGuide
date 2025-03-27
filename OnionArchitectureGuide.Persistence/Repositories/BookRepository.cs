using Microsoft.EntityFrameworkCore;
using OnionArchitectureGuide.Domain.Contracts;
using OnionArchitectureGuide.Domain.Entities;
using OnionArchitectureGuide.Persistence.Data;

namespace OnionArchitectureGuide.Persistence.Repositories
{
    internal class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetAllAsync()
        {
            return await _context.Books.ToListAsync();
        }
    }
}
