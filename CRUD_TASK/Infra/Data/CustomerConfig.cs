using Infra.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>    
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            //builder.HasKey(c => c.Id);
            //builder.Property(c => c.Name).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();
            //builder.Property(c => c.Email).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();

            builder.HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId);
        }
    }
}
