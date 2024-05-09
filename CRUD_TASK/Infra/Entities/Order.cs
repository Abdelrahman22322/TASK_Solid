namespace Infra.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public required Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public required List<OrderItem> OrderItems { get; set; }
    }
}
