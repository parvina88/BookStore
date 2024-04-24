using Domain.Enum;

namespace Contract.Responses
{
    public record SingleAuthorResponse
    {
        public Guid Id { get; init; }
        public string FullName { get; init; }
        public string Address { get; init; }
        public DateTime Birthday { get; init; }
        public string Phone { get; init; }
        public Gender Gender { get; init; }
    }
}
