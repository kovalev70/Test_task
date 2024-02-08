using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Task10.Backend.Models.Domain;
using Task10.Backend.Models.DTO.DepositDTO;
using Task10.Backend.Repositories.IRepositories;

namespace Task10.Backend.Controllers;

[ApiController]
[Route("api/deposit")]
public class DepositController : ControllerBase
{
    private readonly IDepositRepository _repository;
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;
    public DepositController(
        IMapper mapper,
        IDepositRepository repository,
        IConfiguration configuration)
    {
        _mapper = mapper;
        _repository = repository;
        _configuration = configuration;
    }

    [HttpPost]
    public async Task<ActionResult> Create(CreateDepositDto depositDto)
    {
        var depositModel = _mapper.Map<Deposit>(depositDto);
        await _repository.CreateAsync(depositModel);
        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult> GetFinalAmount(
        [FromQuery] decimal amount, 
        [FromQuery] int months)
    {
        decimal finalAmount = Math.Round(
            Convert.ToDecimal(_configuration["BankSettings:InterestRate"])
            / 12 * months * amount + amount, 2);
        return Ok(finalAmount);
    }
}
