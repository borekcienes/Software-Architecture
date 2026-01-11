public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public async Task AddAsync(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
    }
}
