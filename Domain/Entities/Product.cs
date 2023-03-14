namespace Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public int BrandId { get; set; }
    public Brand Brand { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public decimal Prices { get; set; }

    public Product()
    {
        
    }
    public Product(int id, string productName, int brandId,int categoryId, decimal prices)
    {
        Id = id;
        ProductName = productName;
        BrandId = brandId; 
        CategoryId = categoryId; 
        Prices = prices;
    }
    
}