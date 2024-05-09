namespace Infra.Entities;

public class Employee
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public string? Department { get; set; }
    public decimal Salary { get; set; }
}