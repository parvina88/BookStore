namespace Domain.Entities
{
    public class Employee : Person
    {
        public Position Position { get; set; }
        public Guid PositionId { get; set; }
    }
}
