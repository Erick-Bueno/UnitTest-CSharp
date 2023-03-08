using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class productModel
{
    
    public Guid id { get; set; }
    public string productName{get; set;}
    public int productQuantity{get;set;}
}