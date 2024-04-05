namespace Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; init; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
