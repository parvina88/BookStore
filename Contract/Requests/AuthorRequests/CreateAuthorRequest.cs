using Domain.Enum;

namespace Contract.Requests.AuthorRequests
{
    public record CreateAuthorRequest 
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }
    }
}
