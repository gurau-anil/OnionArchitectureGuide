using AutoMapper;
using OnionArchitectureGuide.Application.Abstraction.DTOs;
using OnionArchitectureGuide.Domain.Entities;

namespace OnionArchitectureGuide.Application.Implementation.Mappings
{
    internal class ApplicationProfile: Profile
    {
        public ApplicationProfile()
        {
            CreateMap<BookDto, Book>().ReverseMap();
            CreateMap<Author, AuthorDto>().ReverseMap();
        }
    }
}
