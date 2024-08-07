﻿using MicroRabbit.Banking.Application.Dtos;
using MicroRabbit.Banking.Domain.Entities;

namespace MicroRabbit.Banking.Application.Interfaces;

public interface IAccountService
{
    IEnumerable<Account> GetAccounts();
    void Transfer(AccountTransfer accountTransfer);
}