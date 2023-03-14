namespace Domain.Entities;

public class Brand
{
    public int Id { get; set; }
    public string BrandName { get; set; }
    public List<Product> Products { get; set; }

    public Brand()
    {
        
    }
    public Brand(int id, string brandName)
    {
        Id = id;
        BrandName = brandName;
    }
}