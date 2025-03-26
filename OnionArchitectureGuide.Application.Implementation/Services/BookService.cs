using OnionArchitectureGuide.Application.Abstraction.Contracts;
using OnionArchitectureGuide.Application.Abstraction.DTOs;
using OnionArchitectureGuide.Domain.Contracts;

namespace OnionArchitectureGuide.Application.Implementation.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<BookDto> GetAllBooks()
        {
            return await _bookRepository.GetAllAsync();
        }
    }

    public class AuthorService : IAuthorService
    {
        public Task<AuthorDto> GetAllAuthors()
        {
            throw new NotImplementedException();
        }
    }
}
