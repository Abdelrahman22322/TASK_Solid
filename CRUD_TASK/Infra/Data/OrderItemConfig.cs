using Infra.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data
{
    internal class OrderItemConfig : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            //    builder.HasKey(oi => new { oi.OrderId, oi.ProductId });
            //    builder.Property(oi => oi.Quantity).HasColumnType("INT").IsRequired();
            //    builder.Property(oi => oi.UnitPrice).HasColumnType("Decimal").IsRequired();
            builder.HasKey(e => new { e.OrderId, e.ProductId});
            builder.HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId);
            builder
                .HasOne(oi => oi.Product)
                .WithMany()
                .HasForeignKey(oi => oi.ProductId);

        }
    }
}
