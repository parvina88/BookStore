using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id); //Primary key

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(b => b.PageCount)
                .IsRequired();

            builder.Property(b => b.Price)
                .IsRequired()
                .HasPrecision(4, 2);

            builder.Property(b => b.Language)
                .IsRequired();

            builder.HasOne(b => b.Genre)
                .WithMany(b => b.Books)
                .HasForeignKey(b => b.GenreId); //Foreign key

            builder.HasOne(b => b.Author)
                .WithMany(b => b.Books)
                .HasForeignKey(b => b.AuthorId);  //Foreign key
        }
    }
}
