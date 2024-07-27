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
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infrastructure.IoC;

public static class DependencyContainer
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddTransient<IEventBus, RabbitMqBus>();

        services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, CreateTransferCommandHandler>();
        
        services.AddTransient<IAccountService, AccountService>();
        
        services.AddTransient<IAccountRepository, AccountRepository>();
        services.AddTransient<BankingDbContext>();
    }
}
