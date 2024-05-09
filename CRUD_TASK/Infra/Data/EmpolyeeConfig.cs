using Infra.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>

    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();
            builder.Property(e => e.Department).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();
        }
    }
}
