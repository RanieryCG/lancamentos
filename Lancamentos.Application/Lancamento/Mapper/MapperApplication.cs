using Lancamentos.Application.Lancamento.Command.Criar;
using Lancamentos.Domain.Entidades;

namespace Lancamentos.Application.Lancamento.Mapper;

public static class MapperApplication
{
    public static LancamentoEntidade CommandDebitoParaEntidade(CriarCommand command)
    {
        return new LancamentoEntidade(valor: command.Valor, descricao: command.Descricao, data: command.Data.ToUniversalTime(), tipo: Domain.Enums.TipoLancamentoEnum.Debito);
    }

    public static LancamentoEntidade CommandCreditoParaEntidade(CriarCommand command)
    {
        return new LancamentoEntidade(valor: command.Valor, descricao: command.Descricao, data: command.Data.ToUniversalTime(), tipo: Domain.Enums.TipoLancamentoEnum.Credito);
    }
}
