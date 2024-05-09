using System.ComponentModel.DataAnnotations;

namespace Infra.Entities;

public class OrderItem
{
    [Key]
    public int OrderId { get; set; }
   
    public int ProductId { get; set; }
    public Order? Order { get; set; }
    public  Product? Product { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get;  set; }
}