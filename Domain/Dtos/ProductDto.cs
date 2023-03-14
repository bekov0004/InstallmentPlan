namespace Domain.Dtos;

public class ProductDto
{ 
    public string ProductName { get; set; }
    public string Brand { get; set; }
    public string Category { get; set; }
    public decimal Prices { get; set; }
    public int Commission { get; set; }
    public int Installment { get; set; }
    public decimal TotlPrices { get; set; }
    public decimal InstallmentPlan { get; set; }
    
}