namespace Domain.Entities;

public class Category
{
    public int Id { get; set; }
    public string СategorName { get; set; }
    public List<Product> Products { get; set; }

    public Category()
    {
        
    }

    public Category(int id, string сategorName)
    {
        Id = id;
        СategorName = сategorName; 
    }
}