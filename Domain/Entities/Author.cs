namespace Domain.Entities
{
    public class Author : Person
    {
        public virtual ICollection<Book> Books { get; set; }
    }
}
