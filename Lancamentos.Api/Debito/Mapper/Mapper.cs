using Lancamentos.Application.Lancamento.Command.Criar;
using Lancamentos.Contracts.Lancamento.Credito.Requests;
using Lancamentos.Contracts.Lancamento.Debito.Requests;

namespace Lancamentos.Api.Debito.Mapper;

public static class Mapper
{
    public static CriarCommand RequestParaCommand(CriarDebitoRequest request)
    {
        return new CriarCommand(
            Descricao: request.Descricao, 
            Valor: request.Valor, 
            Data: request.Data, 
            IdUsuario: request.IdUsuario);
    }

    public static CriarCommand RequestParaCommand(CriarCreditoRequest request)
    {
        return new CriarCommand(
            Descricao: request.Descricao,
            Valor: request.Valor,
            Data: request.Data,
            IdUsuario: request.IdUsuario);
    }
}
