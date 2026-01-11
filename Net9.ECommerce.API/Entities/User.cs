public class User : BaseEntity
{
    public string Username { get; set; }
    public string Email { get; set; }

    public string PasswordHash { get; set; }
    public string Role { get; set; }   // Admin / User

    // Navigation Property
    public ICollection<Order> Orders { get; set; }
}
