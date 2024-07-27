using MediatR;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repositories;
using MicroRabbit.Banking.Domain.CommandHandlers;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infrastructure.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Application.Services;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Data.Repositories;
using MicroRabbit.Transfer.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infrastructure.IoC;

public static class DependencyContainer
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddTransient<IEventBus, RabbitMqBus>();

        services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, CreateTransferCommandHandler>();
        
        services.AddTransient<IAccountService, AccountService>();
        services.AddTransient<ITransferService, TransferService>();
        
        services.AddTransient<IAccountRepository, AccountRepository>();
        services.AddTransient<ITransferRepository, TransferRepository>();
        services.AddDbContext<BankingDbContext>();
        services.AddDbContext<TransferDbContext>();
    }
}
