using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Transfer.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransferController : Controller
{
    private readonly ITransferService _transferService;

    public TransferController(ITransferService transferService)
    {
        _transferService = transferService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<TransferLog>> Get()
    {
        return Ok(_transferService.GetTransferLogs());
    }
}