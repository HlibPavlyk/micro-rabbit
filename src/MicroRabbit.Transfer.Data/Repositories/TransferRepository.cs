﻿using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Entities;
using MicroRabbit.Transfer.Domain.Interfaces;

namespace MicroRabbit.Transfer.Data.Repositories;

public class TransferRepository : ITransferRepository
{
    private readonly TransferDbContext _context;

    public TransferRepository(TransferDbContext context)
    {
        _context = context;
    }

    public IEnumerable<TransferLog> GetTransferLogs()
    {
        return _context.TransferLogs;
    }

    public void Add(TransferLog transferLog)
    {
        _context.TransferLogs.Add(transferLog);
        _context.SaveChanges();        
    }
}