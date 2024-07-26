using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Entities;
using MicroRabbit.Banking.Domain.Interfaces;

namespace MicroRabbit.Banking.Data.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly BankingDbContext _context;

    public AccountRepository(BankingDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Account> GetAccounts()
    {
        return _context.Accounts;
    }
}