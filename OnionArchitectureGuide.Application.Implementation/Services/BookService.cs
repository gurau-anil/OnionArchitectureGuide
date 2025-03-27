﻿using AutoMapper;
using OnionArchitectureGuide.Application.Abstraction.Contracts;
using OnionArchitectureGuide.Application.Abstraction.DTOs;
using OnionArchitectureGuide.Domain.Contracts;

namespace OnionArchitectureGuide.Application.Implementation.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<BookDto>> GetAllBooks()
        {
            return _mapper.Map<IEnumerable<BookDto>>(await _bookRepository.GetAllAsync());
        }
    }
}
