using AutoMapper;
using OnionArchitectureGuide.Application.Abstraction.Contracts;
using OnionArchitectureGuide.Application.Abstraction.DTOs;
using OnionArchitectureGuide.Domain.Contracts;

namespace OnionArchitectureGuide.Application.Implementation.Services
{
    internal class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }
        public async Task<List<BookDto>> GetAllBooks()
        {
            return _mapper.Map<List<BookDto>>(await _bookRepository.GetAllAsync());
        }
    }
}
