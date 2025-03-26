using OnionArchitectureGuide.Application.Abstraction.DTOs;

namespace OnionArchitectureGuide.Application.Abstraction.Contracts
{
    public interface IBookService
    {
        Task<BookDto> GetAllBooks();
    }
}
