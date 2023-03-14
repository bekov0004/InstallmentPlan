using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Seeds;

public class SeedData
{
    public static async Task Seed(DataContext context)
    {
        if(context.Categories.Any())return;
        var category = new List<Category>()
        {
            new Category(1, "Смартфон"),
            new Category(2, "Компьютер"),
            new Category(3, "Телевизор")
        };
        context.Categories.AddRange(category);
        await context.SaveChangesAsync();
        
        if(context.Brands.Any())return;
        var brand = new List<Brand>()
        {
            new Brand(1,"Samsung"),
            new Brand(2,"Apple"),
            new Brand(3,"LG"),
        };
        context.Brands.AddRange(brand);
        await context.SaveChangesAsync();
        
        if(context.Products.Any())return;
        var product = new List<Product>()
        {
            new Product(1,"Samsung Galaxy S22 Ultra",1,1,7500),
            new Product(2,"iPhone 14 Pro Max",2,1,14794),
            new Product(3,"TV Samsung, 46 inch (Replica)",1,3,1735),
            new Product(4,"TV LG LED Smart 32LM637BPVA, 32 inches.",3,3,2090),
            new Product(5,"MacBook Air 13 2022",2,2,13949),
            new Product(6,"MacBook Pro 14 2021 Apple M1",2,2,22500),
        };
        context.Products.AddRange(product);
        await context.SaveChangesAsync();
    }
}