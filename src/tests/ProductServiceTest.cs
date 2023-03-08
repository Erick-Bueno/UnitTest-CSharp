using Microsoft.AspNetCore.Mvc;
using Moq;
using Product.Controllers;
using Xunit;

public class ProductServiceTest
{
    [Fact]
   async public void TestName()
    {
        var ProductRepostoryMock = new Mock<IProductRepository>();
        var ProductService = new ProductService(ProductRepostoryMock.Object);

        productModel p1 = new productModel();
        p1.id = Guid.NewGuid();
        p1.productName = "assdsd";
        p1.productQuantity = 3;
       
     
        ProductRepostoryMock.Setup(r => r.createProduct(p1)).ReturnsAsync(p1);

        var result = await ProductService.Create(p1);
        Console.Write(result);
        Assert.Equal(p1, result);
        
    }
    [Fact]
    
    public void TestExeceptionProductName()
    {
        productModel p1 = new productModel();
        p1.id = Guid.NewGuid();
        p1.productName = null;
        p1.productQuantity = 3;

        var ProductRepositoryMock = new Mock<IProductRepository>();

        var prodservice = new ProductService(ProductRepositoryMock.Object);

        Assert.ThrowsAsync<Exception>(() => prodservice.Create(p1));

    }
   
}