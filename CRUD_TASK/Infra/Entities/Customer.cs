﻿namespace Infra.Entities;

public class Customer
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public List<Order>? Orders { get; set; }
}