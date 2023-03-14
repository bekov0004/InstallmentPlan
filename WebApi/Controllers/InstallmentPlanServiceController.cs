using Domain.Dtos;
using Domain.Wrapper;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[Route("[controller]")]
public class InstallmentPlanServiceController:ControllerBase
{
    private readonly InstallmentPlanService _installmentPlanService;

    public InstallmentPlanServiceController(InstallmentPlanService installmentPlanService)
    {
        _installmentPlanService = installmentPlanService;
    }

    [HttpGet("GetProductByInstallment")]
    public async Task<Response<List<ProductDto>>> GetProductByInstallment(string productName, int installmentRange)
    {
        return  await _installmentPlanService.GetProductByInstallment(productName, installmentRange);
    }
}