using Infra.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();
            builder.Property(p => p.Price).HasColumnType("DECIMAL(18,2)").IsRequired();
            builder.Property(p => p.Stock).HasColumnType("INT").IsRequired();

        }
    }
}
