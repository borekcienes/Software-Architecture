public class Order : BaseEntity
{
    public int UserId { get; set; }

    // Navigation
    public User User { get; set; }

    public DateTime OrderDate { get; set; }
    public decimal TotalPrice { get; set; }

    public ICollection<OrderItem> OrderItems { get; set; }
}
