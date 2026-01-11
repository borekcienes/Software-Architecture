public class Product : BaseEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public ICollection<OrderItem> OrderItems { get; set; }
}
