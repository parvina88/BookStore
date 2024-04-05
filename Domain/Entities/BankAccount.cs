namespace Domain.Entities
{
    public class BankAccount : BaseEntity
    {
        public int AccountNumber { get; set; }

        public Customer Customer { get; set; }
        public Guid CustomerId { get; set; }
    }
}
