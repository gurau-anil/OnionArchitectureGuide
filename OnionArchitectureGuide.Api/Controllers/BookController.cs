using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureGuide.Application.Abstraction.Contracts;

namespace OnionArchitectureGuide.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("get-books")]
        public async Task<IActionResult> GetBooks()
        {
            return Ok(await _bookService.GetAllBooks());
        }
    }
}
