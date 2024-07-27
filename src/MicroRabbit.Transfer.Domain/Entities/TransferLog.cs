namespace MicroRabbit.Transfer.Domain.Entities;

public class TransferLog
{
    public int Id { get; set; }
    public int FromAccount { get; set; }
    public int ToAccount { get; set; }
    public decimal TransferAmount { get; set; }
}