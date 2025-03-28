﻿using OnionArchitectureGuide.Application.Abstraction.DTOs;

namespace OnionArchitectureGuide.Application.Abstraction.Contracts
{
    public interface IAuthorService
    {
        Task<List<AuthorDto>> GetAllAuthors();
    }
}
