﻿
namespace OnionArchitectureGuide.Application.Abstraction.DTOs
{
    public class BookDto
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime PublishedOn { get; set; }
        public int AuthorId { get; set; }
        public AuthorDto Author { get; set; }
    }
}
