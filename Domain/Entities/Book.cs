using Domain.Enum;

namespace Domain.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int PageCount { get; set; }
        public BookType Type { get; set; }

        public Genre Genre { get; set; }
        public Guid GenreId { get; set; }




    }
}
