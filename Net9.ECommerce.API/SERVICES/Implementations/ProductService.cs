public class ProductService : IProductService
{
    public async Task<ProductResponseDto> CreateAsync(CreateProductDto dto)
    {
        var product = new Product
        {
            Name = dto.Name,
            Price = dto.Price
        };

        await _repository.AddAsync(product);

        return new ProductResponseDto
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price
        };
    }
}
