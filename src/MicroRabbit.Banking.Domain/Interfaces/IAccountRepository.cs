using MicroRabbit.Banking.Domain.Entities;

namespace MicroRabbit.Banking.Domain.Interfaces;

public interface IAccountRepository
{
    IEnumerable<Account> GetAccounts();
}