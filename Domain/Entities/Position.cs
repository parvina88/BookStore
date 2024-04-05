namespace Domain.Entities
{
    public class Position : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
