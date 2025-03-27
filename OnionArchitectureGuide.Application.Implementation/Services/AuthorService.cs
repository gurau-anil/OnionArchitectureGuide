using AutoMapper;
using OnionArchitectureGuide.Application.Abstraction.Contracts;
using OnionArchitectureGuide.Application.Abstraction.DTOs;
using OnionArchitectureGuide.Domain.Contracts;

namespace OnionArchitectureGuide.Application.Implementation.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _bookRepository;
        private readonly IMapper _mapper;
        public AuthorService(IAuthorRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<AuthorDto>> GetAllAuthors()
        {
            return _mapper.Map<IEnumerable<AuthorDto>>(await _bookRepository.GetAllAsync());
        }
    }
}
