namespace Domain.Entities
{
    public class Customer : Person
    {
        public string Email { get; set; }
        public BankAccount Account { get; set; }
        public Guid AccountId { get; set; }
    }
}
