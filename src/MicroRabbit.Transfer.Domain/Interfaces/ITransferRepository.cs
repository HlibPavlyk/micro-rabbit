using MicroRabbit.Transfer.Domain.Entities;

namespace MicroRabbit.Transfer.Domain.Interfaces;

public interface ITransferRepository
{
    IEnumerable<TransferLog> GetTransferLogs();
    void Add(TransferLog transferLog);
}