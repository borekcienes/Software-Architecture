public interface IProductService
{
    Task<ProductResponseDto> CreateAsync(CreateProductDto dto);
}
