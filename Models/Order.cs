namespace MyMvcApp.Models;

public class Order
{
    public int OrderId { get; set; }
    public string? ProductName { get; set; }
    public int Quantity { get; set; }
}