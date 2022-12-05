using Lancamentos.Application.Common.Persistence;
using Lancamentos.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace Lancamentos.Infrastructure;
public static class Di
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<ILancamentoRepositorio, LancamentoRepositorio>();
        return services;
    }
}
