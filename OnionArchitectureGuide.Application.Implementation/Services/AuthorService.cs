using AutoMapper;
using OnionArchitectureGuide.Application.Abstraction.Contracts;
using OnionArchitectureGuide.Application.Abstraction.DTOs;
using OnionArchitectureGuide.Domain.Contracts;

namespace OnionArchitectureGuide.Application.Implementation.Services
{
    internal class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;
        public AuthorService(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }
        public async Task<List<AuthorDto>> GetAllAuthors()
        {
            return _mapper.Map<List<AuthorDto>>(await _authorRepository.GetAllAsync());
        }
    }
}
