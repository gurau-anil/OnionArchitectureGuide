
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureGuide.Application.Abstraction.Contracts;

namespace OnionArchitectureGuide.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet("get-authors")]
        public async Task<IActionResult> GetBooks()
        {
            return Ok(await _authorService.GetAllAuthors());
        }
    }
}
