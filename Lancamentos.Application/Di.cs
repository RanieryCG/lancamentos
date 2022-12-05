using Lancamentos.Application.Lancamento.Command.Criar;
using Microsoft.Extensions.DependencyInjection;

namespace Lancamentos.Application;

public static class Di
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ICriarCommand, CriarCommandHandle>(); 
        return services;
    }
}