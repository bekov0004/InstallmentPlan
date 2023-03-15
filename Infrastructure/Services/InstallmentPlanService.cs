using System.Diagnostics;
using AutoMapper;
using Domain.Dtos;
using Domain.Wrapper;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class InstallmentPlanService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public InstallmentPlanService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Response<List<ProductDto>>> GetProductByInstallment(string productName, int installmentRange)
    {
        var category = _context.Products.FirstOrDefaultAsync(x=>x.ProductName.ToLower().Contains(productName.ToLower())).Result.CategoryId;
        int commission=0;
        var query = _context.Products.AsQueryable();
        
        
        if (productName != null && installmentRange != null && category==1)
        {
            query = query.Where(x => x.CategoryId == 1 & x.ProductName.Contains(productName));
            commission = installmentRange switch
            {
                12 => 3,
                18 => 6,
                24 => 9,
                _ => commission
            };
        }
        
        if (productName != null && installmentRange != null && category==2)
        {
            query = query.Where(x => x.CategoryId == 2 & x.ProductName.ToLower().Contains(productName.ToLower()));
            commission = installmentRange switch
            {
                18 => 4,
                24 => 8,
                _ => commission
            };
        }
        
        if (productName != null && installmentRange != null && category==3)
        {
            query = query.Where(x => x.CategoryId == 3 & x.ProductName.ToLower().Contains(productName.ToLower()));
            commission = installmentRange switch
            { 
                24 => 5,
                _ => commission
            };
        }

        var filter =await query.Select(x =>
            new ProductDto()
            {
                ProductName = x.ProductName,
                Brand = x.Brand.BrandName,
                Category = x.Category.СategorName,
                Prices = x.Prices,
                Commission = commission,
                Installment = installmentRange,
                TotlPrices = (x.Prices) + ((x.Prices * commission) / 100),
                InstallmentPlan = ((x.Prices) + ((x.Prices * commission) / 100)) / installmentRange
            }).ToListAsync(); 
        return new Response<List<ProductDto>>(filter);
        


    }

    

}