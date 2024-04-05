namespace Domain.Entities
{
    public class Customer : Person
    {
        public string Email { get; set; }
        public virtual ICollection<BankAccount> Accounts { get; set; }
    }
}
