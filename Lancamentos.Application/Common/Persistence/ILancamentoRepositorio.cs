using Lancamentos.Domain.Entidades;

namespace Lancamentos.Application.Common.Persistence;

public interface ILancamentoRepositorio
{
    void Criar(LancamentoEntidade lancamento);
}
