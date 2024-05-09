﻿namespace Infra.Entities;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public decimal Price { get; set; }
    public List<OrderItem>? OrderItems { get; set; }
    public string? Stock { get; set; }
}