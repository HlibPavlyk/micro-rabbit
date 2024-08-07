﻿using MicroRabbit.Banking.Application.Dtos;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BankingController :ControllerBase
{
    private readonly IAccountService _accountService;

    public BankingController(IAccountService accountService)
    {
        _accountService = accountService;
    }
    
    [HttpGet]
    public ActionResult<IEnumerable<Account>> Get()
    {
        return Ok(_accountService.GetAccounts());   
    }
    [HttpPost]
    public IActionResult Post([FromBody] AccountTransfer accountTransfer)
    {
        _accountService.Transfer(accountTransfer);
        return Ok(accountTransfer);
    }
}