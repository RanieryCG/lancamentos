using Lancamentos.Application.Common.Persistence;
using Lancamentos.Domain.Entidades;

namespace Lancamentos.Infrastructure.Persistence;
public class LancamentoRepositorio : ILancamentoRepositorio
{
    private readonly List<LancamentoEntidade> _lancamentos = new();


    public void Criar(LancamentoEntidade lancamento)
    {
        _lancamentos.Add(lancamento);
    }
}
