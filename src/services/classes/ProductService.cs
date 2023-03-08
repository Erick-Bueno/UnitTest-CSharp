public class ProductService : IProductService
{
    public IProductRepository productRepository{get; set;}

    public ProductService(IProductRepository productRepository)
    {
        this.productRepository = productRepository;
    }

    public async Task<productModel> Create (productModel prod)
    {
       if(String.IsNullOrEmpty(prod.productName)){
        throw new Exception("nome invalido");
       }
       var product = await productRepository.createProduct(prod);

       return product;
    }
}