public class ProductRepository : IProductRepository
{
    public AppDbContext _context{get; set;}

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<productModel> createProduct(productModel product)
    {
        await _context.products.AddAsync(product);
        await _context.SaveChangesAsync();
        return product;
    }
}