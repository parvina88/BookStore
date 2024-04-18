using Domain.Enum;

namespace Contract.Requests.BookRequest
{
    public record UpdateBookRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int PageCount { get; set; }
        public BookType Type { get; set; }
        public string Language { get; set; }
        public Guid GenreId { get; set; }
        public Guid AuthorId { get; set; }

    }
}
