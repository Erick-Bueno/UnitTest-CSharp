public interface IProductService
{
    public Task<productModel> Create(productModel product);
}