public interface IProductRepository{
    public Task<productModel> createProduct(productModel product);
}