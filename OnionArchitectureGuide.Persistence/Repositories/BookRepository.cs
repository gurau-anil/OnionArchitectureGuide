using OnionArchitectureGuide.Domain.Contracts;
using OnionArchitectureGuide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureGuide.Persistence.Repositories
{
    internal class BookRepository : IBookRepository
    {
        private readonly IBookRepository _bookRepository;
        public BookRepository(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _bookRepository.GetAllAsync();
        }
    }
}
