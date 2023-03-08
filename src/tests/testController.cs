using Microsoft.AspNetCore.Mvc;
using Moq;
using Product.Controllers;
using Xunit;

public class testController
{
    [Fact]
    public async void TestName()
    {
        productModel p1 = new productModel();
        p1.id = Guid.NewGuid();
        p1.productName = "assad";
        p1.productQuantity = 3;

        var prodservice = new Mock<IProductService>();
        ProductController pcontroller = new ProductController(prodservice.Object);
        //simulando chamado do metodo no controller
        prodservice
            .Setup(service => service.Create(p1))
            .ReturnsAsync(p1);

        var result =await pcontroller.Post(p1);

        var objectresult = Assert.IsType<OkObjectResult>(result.Result);
        Assert.IsType<productModel>(objectresult.Value);



       
    }
}