using Domain.Entities;

namespace Contract.Responses
{
    public record GetAllBookResponses
    {
        public IEnumerable<Book> Items { get; set; }
    }
}
