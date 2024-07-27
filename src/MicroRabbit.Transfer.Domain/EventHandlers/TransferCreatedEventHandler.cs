using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events;

namespace MicroRabbit.Transfer.Domain.EventHandlers;

public class TransferCreatedEventHandler : IEventHandler<TransferCreatedEvent>
{
    public TransferCreatedEventHandler() { }
    
    public Task Handle(TransferCreatedEvent @event)
    {
        return Task.CompletedTask;
    }
}